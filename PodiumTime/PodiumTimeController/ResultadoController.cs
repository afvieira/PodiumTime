using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodiumTimeModels;

namespace PodiumTimeController {
    public class ResultadoController {

        public ResultadoController() {
        }

        public List<Resultado> GetAll(bool itemBranco = false) {
            List<Resultado> result = new List<Resultado>();

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                result = (from e in ctx.Resultados
                          select e).ToList();
            }

            if(itemBranco) {
                result.Insert(0, new Resultado() { ID = -1 });
            }

            return result;
        }

        public List<Resultado> GetAllByProva(int provaID, bool itemBranco = false) {
            List<Resultado> result = new List<Resultado>();

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                result = (from e in ctx.Resultados
                          where e.ProvaID == provaID
                          select e).ToList();
            }

            if(itemBranco) {
                result.Insert(0, new Resultado() { ID = -1 });
            }

            return result;
        }

        public Resultado Find(int id) {
            Resultado result = null;

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                result = (from e in ctx.Resultados
                          where e.ID == id
                          select e).FirstOrDefault();
            }

            return result;
        }

        public void Delete(int resultadoID) {
            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                var result = from e in ctx.Resultados
                             where e.ID == resultadoID
                             select e;

                ctx.Resultados.DeleteOnSubmit(result.Single());
                ctx.SubmitChanges();
            }
        }

        public void Save(PodiumTimeModels.Resultado resultadoSlecionado) {

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                if(resultadoSlecionado != null && resultadoSlecionado.ID > 0) {
                    var res = (from e in ctx.Resultados
                               where e.ID == resultadoSlecionado.ID
                               select e).Single();

                    res.ID = resultadoSlecionado.ID;
                    res.NomeParticipante = resultadoSlecionado.NomeParticipante;
                    res.Equipa = resultadoSlecionado.Equipa;
                    res.Dorsal = resultadoSlecionado.Dorsal;
                    res.DocIdentificacao = resultadoSlecionado.DocIdentificacao;
                    res.ProvaID = resultadoSlecionado.ProvaID;

                    ctx.SubmitChanges();
                } else {
                    ctx.Resultados.InsertOnSubmit(resultadoSlecionado);
                    ctx.SubmitChanges();
                }
            }
        }

        public bool isValid(Resultado result) {
            return (this.Valid(result).Count == 0);
        }

        public List<string> Valid(Resultado result) {
            List<string> messages = new List<string>();

            if(string.IsNullOrWhiteSpace(result.NomeParticipante)) {
                messages.Add("Nome participante");
            }
            if(result.Dorsal == null || result.Dorsal <= 0) {
                messages.Add("Dorsal");
            }

            return messages;
        }
    }
}
