using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodiumTimeModels;

namespace PodiumTimeController {
    public class InscricaoController {

        public InscricaoController() {
        }

        public List<Inscricao> GetAll(bool itemBranco = false) {
            List<Inscricao> result = new List<Inscricao>();

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                result = (from e in ctx.Inscricaos
                          select e).ToList();
            }

            if(itemBranco) {
                result.Insert(0, new Inscricao() { ID = -1 });
            }

            return result;
        }

        public List<Inscricao> GetAllByEvento(int eventoID, bool itemBranco = false) {
            List<Inscricao> result = new List<Inscricao>();

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                result = (from e in ctx.Inscricaos
                          where e.EventoID == eventoID
                          select e).ToList();
            }

            if(itemBranco) {
                result.Insert(0, new Inscricao() { ID = -1 });
            }

            return result;
        }

        public Inscricao Find(int id) {
            Inscricao result = null;

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                result = (from e in ctx.Inscricaos
                          where e.ID == id
                          select e).FirstOrDefault();
            }

            return result;
        }

        public void Delete(int inscricaoID) {
            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                var inscricao = from e in ctx.Inscricaos
                                where e.ID == inscricaoID
                                select e;

                ctx.Inscricaos.DeleteOnSubmit(inscricao.Single());
                ctx.SubmitChanges();
            }
        }

        public void Save(PodiumTimeModels.Inscricao inscrSlecionada) {

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                if(inscrSlecionada != null && inscrSlecionada.ID > 0) {
                    var inscr = (from e in ctx.Inscricaos
                                 where e.ID == inscrSlecionada.ID
                                 select e).Single();

                    inscr.ID = inscrSlecionada.ID;
                    inscr.Nome = inscrSlecionada.Nome;
                    inscr.Pago = inscrSlecionada.Pago;
                    inscr.Sexo = inscrSlecionada.Sexo;
                    inscr.TamanhoJersey = inscrSlecionada.TamanhoJersey;
                    inscr.TipoInscricao = inscrSlecionada.TipoInscricao;
                    inscr.EventoID = inscrSlecionada.EventoID;
                    inscr.Equipa = inscrSlecionada.Equipa;
                    inscr.Email = inscrSlecionada.Email;
                    inscr.Dorsal = inscrSlecionada.Dorsal;
                    inscr.DocIdentificacao = inscrSlecionada.DocIdentificacao;
                    inscr.DataInscricao = inscrSlecionada.DataInscricao;
                    inscr.Contacto = inscrSlecionada.Contacto;

                    ctx.SubmitChanges();
                } else {
                    ctx.Inscricaos.InsertOnSubmit(inscrSlecionada);
                    ctx.SubmitChanges();
                }
            }
        }

        public bool isValid(Inscricao Inscricao) {
            return (this.Valid(Inscricao).Count == 0);
        }

        public List<string> Valid(Inscricao Inscricao) {
            List<string> messages = new List<string>();

            if(string.IsNullOrWhiteSpace(Inscricao.Nome)) {
                messages.Add("Nome");
            }

            return messages;
        }
    }
}
