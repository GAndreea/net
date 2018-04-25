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

        public List<CARTEDTO> S_listare_carti(int genId)
        {
            List<CARTE> carti = ClassLibrary1.Program.listare_carti(genId);
            return carti.Select(x => S_carte_dto(x)).ToList();
        }

        public void S_achizitie_carte(CARTEDTO c, int nrExemplare)
        {
            CARTE c1 = S_dto_carte(c);
            
            ClassLibrary1.Program.achizitie_carte(S_dto_carte(c), nrExemplare);
        }

        public int S_get_genId(string gen)
        {
            return ClassLibrary1.Program.get_genId(gen);
        }

        public AUTORDTO S_get_autor(int AutorId)
        {
            return S_autor_dto(ClassLibrary1.Program.get_autor(AutorId));
        }

        public int S_verifica_cititor(string email)
        {
            return ClassLibrary1.Program.verifica_cititor(email);
        }

        public int S_get_stare(int cititorId)
        {
            return ClassLibrary1.Program.get_stare(cititorId);
        }

        public void S_adauga_cititor(CITITORDTO c)
        {
            ClassLibrary1.Program.adauga_cititor(S_dto_cititor(c));
        }

        public void S_imprumuta_carte(int carteId, int cititorId)
        {
            ClassLibrary1.Program.imprumuta_carte(carteId, cititorId);
        }

        public void S_restituie_carte(int imprumutId)
        {
            ClassLibrary1.Program.restituie_carte(imprumutId);
        }

        public void S_adauga_review(REVIEWDTO r)
        {
            ClassLibrary1.Program.adauga_review(S_dto_review(r));
        }

        public int S_verifica_carte(string nume_autor = "", string prenume_autor = "", string titlu_carte = "")
        {
            return ClassLibrary1.Program.verifica_carte(nume_autor, prenume_autor, titlu_carte);
        }

        public DateTime S_verifica_data(string nume_autor = "", string prenume_autor = "", string titlu_carte = "")
        {
            return ClassLibrary1.Program.verifica_data(nume_autor, prenume_autor, titlu_carte);
        }

        public List<IMPRUMUTDTO> S_get_imprumuturi(int cititorId)
        {
            return ClassLibrary1.Program.get_imprumuturi(cititorId).Select(x => S_imprumut_dto(x)).ToList(); 
        }

        public CARTEDTO S_get_carte(int CarteId)
        {
            return S_carte_dto(ClassLibrary1.Program.get_carte(CarteId));
        }

        public  int S_get_nrCititori()
        {
            return ClassLibrary1.Program.get_nrCititori();
        }

        public GENDTO S_gen_dto(GEN g)
        {
            //var lista = g.CARTE.Select(x => S_carte_dto(x)).ToList();
            GENDTO g1 = new GENDTO()
            {
                Descriere = g.Descriere
                //CARTE = lista
            };
            return g1;
        }

        public CARTEDTO S_carte_dto(CARTE c)
        {
            //var lista = new List<IMPRUMUTDTO>();
            if (c.IMPRUMUT!=null)
            {
               // lista = c.IMPRUMUT.Select(x => S_imprumut_dto(x)).ToList();
            }
            CARTEDTO c1 = new CARTEDTO()
            {
                CarteId = c.CarteId,
                AutorId = c.AutorId,
                Titlu = c.Titlu
              //  GEN = S_gen_dto(c.GEN),
               // IMPRUMUT = lista,
              //  AUTOR = S_autor_dto(c.AUTOR)
            };
            return c1;
        }

        public AUTORDTO S_autor_dto(AUTOR a)
        {
            //var lista = new List<CARTEDTO>();
            if (a.CARTE != null )
            {
             //  lista = a.CARTE.Select(x => S_carte_dto(x)).ToList();
            }
            AUTORDTO a1 = new AUTORDTO()
            {
                AutorId = a.AutorId,
                Nume = a.Nume,
                Prenume = a.Prenume
            //    CARTE = lista
            };
            return a1;
        }

        public IMPRUMUTDTO S_imprumut_dto(IMPRUMUT i)
        {
            //var lista = new List<REVIEWDTO>();
            if (i.REVIEW != null)
            {
                foreach (REVIEW r in i.REVIEW)
                {
              //      REVIEWDTO r1 = S_review_dto(r);
                //    lista.Add(r1);
                }
            }
            IMPRUMUTDTO i1 = new IMPRUMUTDTO()
            {
                ImprumutId = i.ImprumutId,
                CarteId = i.CarteId,
                CititorId = i.CititorId,
                DataImprumut = i.DataImprumut,
                DataScadenta = i.DataScadenta,
                DataRestituire = i.DataRestituire         
              //  REVIEW = lista
            };
            return i1;
        }

        public REVIEWDTO S_review_dto(REVIEW r)
        {
            return new REVIEWDTO()
            {
                ReviewId = r.ReviewId,
                ImprumutId = r.ImprumutId,
                Text = r.Text
            };
        }

        public CITITORDTO S_cititor_dto(CITITOR c)
        {
            var lista = new List<IMPRUMUTDTO>();
            if (c.IMPRUMUT != null)
            {
                lista = c.IMPRUMUT.Select(x => S_imprumut_dto(x)).ToList();
            }
            return new CITITORDTO()
            {
                CititorId = c.CititorId,
                Nume = c.Nume,
                Prenume = c.Prenume,
                Adresa = c.Adresa,
                Email = c.Email,
                Stare = c.Stare,
                IMPRUMUT = lista
            };
        }

        public GEN S_dto_gen(GENDTO g)
        {
            var lista = new List<CARTE>();
            if (g.CARTE !=null)
            {
                lista = g.CARTE.Select(x => S_dto_carte(x)).ToList(); ;
            }
            return new GEN()
            {
                GenId = g.GenId,
                Descriere = g.Descriere,
                CARTE = lista
            };
            
        }

        public CARTE S_dto_carte(CARTEDTO c)
        {
            var lista = new List<IMPRUMUT>();
            if (c.IMPRUMUT != null)
            {
                lista = c.IMPRUMUT.Select(x => S_dto_imprumut(x)).ToList();
            }
            return new CARTE()
            {
                CarteId = c.CarteId,
                AutorId = c.AutorId,
                Titlu = c.Titlu,
                AUTOR = S_dto_autor(c.AUTOR),
                IMPRUMUT = lista,
                GEN = S_dto_gen(c.GEN)
            };
        }

        public AUTOR S_dto_autor(AUTORDTO a)
        {
            var lista = new List<CARTE>();
            if (a.CARTE!=null)
            {
                lista = a.CARTE.Select(x => S_dto_carte(x)).ToList();
            }
                      
            return new AUTOR()
            {
                AutorId = a.AutorId,
                Nume = a.Nume,
                Prenume = a.Prenume,
                CARTE = lista
            };
        }

        public IMPRUMUT S_dto_imprumut(IMPRUMUTDTO i)
        {
            var lista = new List<REVIEW>();
            if (i.REVIEW != null)
            {
                lista = i.REVIEW.Select(x => S_dto_review(x)).ToList();
            }
            return new IMPRUMUT()
            {
                ImprumutId = i.ImprumutId,
                CarteId = i.CarteId,
                CititorId = i.CititorId,
                DataImprumut = i.DataImprumut,
                DataScadenta = i.DataScadenta,
                DataRestituire = i.DataRestituire,
                CARTE = S_dto_carte(i.CARTE),
                CITITOR = S_dto_cititor(i.CITITOR),
                REVIEW = lista
            };
        }

        public REVIEW S_dto_review(REVIEWDTO r)
        {
            return new REVIEW()
            {
                ReviewId = r.ReviewId,
                ImprumutId = r.ImprumutId,
                Text = r.Text,
                IMPRUMUT = S_dto_imprumut(r.IMPRUMUT)
            };
        }

        public CITITOR S_dto_cititor(CITITORDTO c)
        {
            var lista = new List<IMPRUMUT>();
            if (c.IMPRUMUT!=null)
            {
                lista = c.IMPRUMUT.Select(x => S_dto_imprumut(x)).ToList();
            }
            
            return new CITITOR()
            {
                CititorId = c.CititorId,
                Nume = c.Nume,
                Prenume = c.Prenume,
                Adresa = c.Adresa,
                Email = c.Email,
                Stare = c.Stare,
                IMPRUMUT = lista
            };
        }

        public void S_adauga_autor(AUTORDTO a)
        {
            ClassLibrary1.Program.adauga_autor(S_dto_autor(a));
        }
        
        public AUTORDTO S_get_autor_by_name(string name)
        {
            AUTOR a = ClassLibrary1.Program.get_autor_by_name(name);
            if (a!=null)
            {
                return S_autor_dto(a);
            }
            return null;
        }

        public GENDTO S_get_gen_by_name(string name)
        {
            GEN g = ClassLibrary1.Program.get_gen_by_name(name);
            if (g!=null)
            {
                return S_gen_dto(g);

            }
            return null;
        }

        public void S_adauga_carte(CARTEDTO c)
        {
            ClassLibrary1.Program.adauga_carte(S_dto_carte(c));
        }

        public void S_aduga_gen(GENDTO g)
        {
            ClassLibrary1.Program.adauga_gen(S_dto_gen(g));
        }
    }
}
