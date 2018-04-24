using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassLibrary1;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<CARTE> S_listare_carti(int genId)
        {
            return ClassLibrary1.Program.listare_carti(genId);
        }

        public void S_achizitie_carte(CARTE c, int nrExemplare)
        {
            ClassLibrary1.Program.achizitie_carte(c, nrExemplare);
        }

        public int S_get_genId(string gen)
        {
            return ClassLibrary1.Program.get_genId(gen);
        }

        public AUTOR S_get_autor(int AutorId)
        {
            return ClassLibrary1.Program.get_autor(AutorId);
        }

        public int S_verifica_cititor(string email)
        {
            return ClassLibrary1.Program.verifica_cititor(email);
        }

        public int S_get_stare(int cititorId)
        {
            return ClassLibrary1.Program.get_stare(cititorId);
        }

        public void S_adauga_cititor(CITITOR c)
        {
            ClassLibrary1.Program.adauga_cititor(c);
        }

        public void S_imprumuta_carte(int carteId, int cititorId)
        {
            ClassLibrary1.Program.imprumuta_carte(carteId, cititorId);
        }

        public void S_restituie_carte(int imprumutId)
        {
            ClassLibrary1.Program.restituie_carte(imprumutId);
        }

        public void S_adauga_review(REVIEW r)
        {
            ClassLibrary1.Program.adauga_review(r);
        }

        public int S_verifica_carte(string nume_autor = "", string prenume_autor = "", string titlu_carte = "")
        {
            return ClassLibrary1.Program.verifica_carte(nume_autor, prenume_autor, titlu_carte);
        }

        public DateTime S_verifica_data(string nume_autor = "", string prenume_autor = "", string titlu_carte = "")
        {
            return ClassLibrary1.Program.verifica_data(nume_autor, prenume_autor, titlu_carte);
        }

        public List<IMPRUMUT> S_get_imprumuturi(int cititorId)
        {
            return ClassLibrary1.Program.get_imprumuturi(cititorId);
        }

        public CARTE S_get_carte(int CarteId)
        {
            return ClassLibrary1.Program.get_carte(CarteId);
        }

        public  int S_get_nrCititori()
        {
            return ClassLibrary1.Program.get_nrCititori();
        }

        
    }
}
