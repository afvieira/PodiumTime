using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodiumTimeModels;

namespace PodiumTimeController {
    public class EventoController {

        public EventoController() {
        }

        public List<Evento> GetAll(bool itemBranco = false) {
            List<Evento> result = new List<Evento>();

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                result = (from e in ctx.Eventos
                          select e).ToList();
            }

            if(itemBranco) {
                result.Insert(0, new Evento() { ID = -1 });
            }

            return result;
        }

        public Evento Find(int id) {
            Evento result = null;

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                result = (from e in ctx.Eventos
                          where e.ID == id
                          select e).FirstOrDefault();
            }

            return result;
        }

        public void Delete(int eventoID) {
            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                var evento = from e in ctx.Eventos
                             where e.ID == eventoID
                             select e;

                ctx.Eventos.DeleteOnSubmit(evento.Single());
                ctx.SubmitChanges();
            }
        }

        public void Save(PodiumTimeModels.Evento eventoSelecionado) {

            using(PodiumTimeModelsDataContext ctx = new PodiumTimeModelsDataContext()) {
                if(eventoSelecionado != null && eventoSelecionado.ID > 0) {
                    var evento = (from e in ctx.Eventos
                                  where e.ID == eventoSelecionado.ID
                                  select e).Single();

                    evento.ID = eventoSelecionado.ID;
                    evento.Nome = eventoSelecionado.Nome;
                    evento.Data = eventoSelecionado.Data;
                    evento.Cancelado = eventoSelecionado.Cancelado;
                    evento.Descricao = eventoSelecionado.Descricao;

                    ctx.SubmitChanges();
                } else {
                    ctx.Eventos.InsertOnSubmit(eventoSelecionado);
                    ctx.SubmitChanges();
                }
            }
        }

        public bool isValid(Evento evento) {
            return (this.Valid(evento).Count == 0);
        }

        public List<string> Valid(Evento evento) {
            List<string> messages = new List<string>();

            if(string.IsNullOrWhiteSpace(evento.Nome)) {
                messages.Add("O nome é obrigatório");
            }

            return messages;
        }
    }
}
