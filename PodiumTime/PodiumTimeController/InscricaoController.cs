using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodiumTimeModels;

namespace PodiumTimeController {
    public class InscricaoController {
        PodiumTimeModelsDataContext ctx;

        public InscricaoController() {
            ctx = new PodiumTimeModelsDataContext();
        }

        public List<Inscricao> GetAll(bool itemBranco = false) {
            List<Inscricao> result = new List<Inscricao>();

            result = (from e in ctx.Inscricaos
                      select e).ToList();

            if(itemBranco) {
                result.Insert(0, new Inscricao() { ID = -1 });
            }

            return result;
        }

        public List<Inscricao> GetAllByEvento(int eventoID, bool itemBranco = false) {
            List<Inscricao> result = new List<Inscricao>();

            result = (from e in ctx.Inscricaos
                      where e.EventoID == eventoID
                      select e).ToList();

            if(itemBranco) {
                result.Insert(0, new Inscricao() { ID = -1 });
            }

            return result;
        }

        public Inscricao Find(int id) {
            Inscricao result = null;

            result = (from e in ctx.Inscricaos
                      where e.ID == id
                      select e).FirstOrDefault();

            return result;
        }

        public bool isValid(Inscricao Inscricao) {
            return (this.Valid(Inscricao).Count == 0);
        }

        public List<string> Valid(Inscricao Inscricao) {
            List<string> messages = new List<string>();

            if(string.IsNullOrWhiteSpace(Inscricao.Nome)) {
                messages.Add("O nome é obrigatório");
            }

            return messages;
        }
    }
}
