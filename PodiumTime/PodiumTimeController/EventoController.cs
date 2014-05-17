using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodiumTimeModels;

namespace PodiumTimeController {
    public class EventoController {
        PodiumTimeModelsDataContext ctx;

        public EventoController() {
            ctx = new PodiumTimeModelsDataContext();
        }

        public List<Evento> GetAll(bool itemBranco = false) {
            List<Evento> result = new List<Evento>();

            result = (from e in ctx.Eventos
                      select e).ToList();

            if(itemBranco) {
                result.Insert(0, new Evento() { ID = -1 });
            }

            return result;
        }

        public Evento Find(int id) {
            Evento result = null;

            //result = from e in ctx.Eventos
            //         where e.ID == id
            //         select e;

            return result;
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
