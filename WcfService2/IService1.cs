using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);


        [OperationContract]
        List<CARTEDTO> S_listare_carti(int genId);

        [OperationContract]
        void S_achizitie_carte(CARTEDTO c, int nrExemplare);

        [OperationContract]
        int S_get_genId(string gen);

        [OperationContract]
        AUTOR S_get_autor(int AutorId);

        [OperationContract]
        int S_verifica_cititor(string email);

        [OperationContract]
        int S_get_stare(int cititorId);

        [OperationContract]
        void S_adauga_cititor(CITITORDTO c);

        [OperationContract]
        void S_imprumuta_carte(int carteId, int cititorId);

        [OperationContract]
        void S_restituie_carte(int imprumutId);

        [OperationContract]
        void S_adauga_review(REVIEWDTO r);

        [OperationContract]
        int S_verifica_carte(string nume_autor = "", string prenume_autor = "", string titlu_carte = "");

        [OperationContract]
        DateTime S_verifica_data(string nume_autor = "", string prenume_autor = "", string titlu_carte = "");

        [OperationContract]
        List<IMPRUMUTDTO> S_get_imprumuturi(int cititorId);

        [OperationContract]
        CARTEDTO S_get_carte(int CarteId);

        [OperationContract]
        int S_get_nrCititori();

        [OperationContract]
        GENDTO S_gen_dto(GEN g);

        [OperationContract]
        CARTEDTO carte_dto(CARTE c);

        [OperationContract]
        AUTORDTO autor_dto
        
    }


    [DataContract]
    public partial class AUTORDTO
    {
        public AUTORDTO()
        {
            this.CARTE = new HashSet<CARTEDTO>();
        }

       
        [DataMember]
        public string Nume { get; set; }
        [DataMember]
        public string Prenume { get; set; }

        [DataMember]
        public virtual ICollection<CARTEDTO> CARTE { get; set; }

    }

    [DataContract]
    public partial class CARTEDTO
    {
        public CARTEDTO()
        {
            this.IMPRUMUT = new HashSet<IMPRUMUTDTO>();
        }

       
        [DataMember]
        public string Titlu { get; set; }
     
        [DataMember]
        public virtual AUTORDTO AUTOR { get; set; }
        [DataMember]
        public virtual ICollection<IMPRUMUTDTO> IMPRUMUT { get; set; }
        [DataMember]
        public virtual GENDTO GEN { get; set; }
    }

    [DataContract]
    public partial class CITITORDTO
    {
        public CITITORDTO()
        {
            this.IMPRUMUT = new HashSet<IMPRUMUTDTO>();
        }

        
        [DataMember]
        public string Nume { get; set; }
        [DataMember]
        public string Prenume { get; set; }
        [DataMember]
        public string Adresa { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public byte[] Stare { get; set; }
        [DataMember]
        public virtual ICollection<IMPRUMUTDTO> IMPRUMUT { get; set; }

    }

    [DataContract]
    public partial class GENDTO
    {
        public GENDTO()
        {
            this.CARTE = new HashSet<CARTEDTO>();
        }

       
        [DataMember]
        public string Descriere { get; set; }
        [DataMember]
        public virtual ICollection<CARTEDTO> CARTE { get; set; }

    }

    [DataContract]
    public partial class IMPRUMUTDTO
    {
        public IMPRUMUTDTO()
        {
            this.REVIEW = new HashSet<REVIEWDTO>();
        }

        
        [DataMember]
        public Nullable<System.DateTime> DataImprumut { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DataScadenta { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DataRestituire { get; set; }

        [DataMember]
        public virtual CARTEDTO CARTE { get; set; }
        [DataMember]
        public virtual CITITORDTO CITITOR { get; set; }
        [DataMember]
        public virtual ICollection<REVIEWDTO> REVIEW { get; set; }
    }

    [DataContract]
    public  partial class REVIEWDTO
    {
       
        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public virtual IMPRUMUTDTO IMPRUMUT { get; set; }
    }
}
