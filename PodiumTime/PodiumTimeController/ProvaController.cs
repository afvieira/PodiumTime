using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodiumTimeModels;

namespace PodiumTimeController {
    public class ProvaController {

        public ProvaController() {
        }

        public List<Prova> GetAll(bool itemBranco = false) {
            List<Prova> result = new List<Prova>();

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                result = (from e in ctx.Provas
                          select e).ToList();
            }

            if(itemBranco) {
                result.Insert(0, new Prova() { ID = -1 });
            }

            return result;
        }

        public List<Prova> GetAllByEvento(int eventoID, bool itemBranco = false) {
            List<Prova> result = new List<Prova>();

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                result = (from e in ctx.Provas
                          where e.EventoID == eventoID
                          select e).ToList();
            }

            if(itemBranco) {
                result.Insert(0, new Prova() { ID = -1 });
            }

            return result;
        }

        public Prova Find(int id) {
            Prova result = null;

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                result = (from e in ctx.Provas
                          where e.ID == id
                          select e).FirstOrDefault();
            }

            return result;
        }

        public void Delete(int provaID) {
            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                var prova = from e in ctx.Provas
                            where e.ID == provaID
                            select e;

                ctx.Provas.DeleteOnSubmit(prova.Single());
                ctx.SubmitChanges();
            }
        }

        public void Save(PodiumTimeModels.Prova provaSlecionada) {

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                if(provaSlecionada != null && provaSlecionada.ID > 0) {
                    var prova = (from e in ctx.Provas
                                 where e.ID == provaSlecionada.ID
                                 select e).Single();

                    prova.ID = provaSlecionada.ID;
                    prova.Nome = provaSlecionada.Nome;
                    prova.Descricao = provaSlecionada.Descricao;
                    prova.Distancia = provaSlecionada.Distancia;
                    prova.EventoID = provaSlecionada.EventoID;

                    ctx.SubmitChanges();
                } else {
                    ctx.Provas.InsertOnSubmit(provaSlecionada);
                    ctx.SubmitChanges();
                }
            }
        }

        public bool isValid(Prova prova) {
            return (this.Valid(prova).Count == 0);
        }

        public List<string> Valid(Prova prova) {
            List<string> messages = new List<string>();

            if(string.IsNullOrWhiteSpace(prova.Nome)) {
                messages.Add("Nome");
            }

            return messages;
        }
    }
}
