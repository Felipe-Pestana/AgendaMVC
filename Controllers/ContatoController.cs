using Models;
using Services;
using System.Collections.Generic;

namespace Controllers
{
    public class ContatoController
    {

        public Contato InserirContato(Contato contato)
        {
            return new ContatoServices().InserirContato(contato);
        }

        public List<Contato> ConsultaTodos()
        {
            return new ContatoServices().ConsultaTodos();
        }
    }
}
