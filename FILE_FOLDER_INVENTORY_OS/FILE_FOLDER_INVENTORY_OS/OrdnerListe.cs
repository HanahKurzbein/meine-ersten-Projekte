using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE_FOLDER_INVENTORY
{
    public class OrdnerListe
    {
        private List<Ordner> allordner = new List<Ordner>();
        public List<Ordner> Allordner { get => allordner; set => allordner = value; }
        public OrdnerListe()
        {

        }
    }
}
