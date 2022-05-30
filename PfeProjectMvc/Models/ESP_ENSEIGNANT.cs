//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PfeProjectMvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESP_ENSEIGNANT
    {
        public string ID_ENS { get; set; }
        public string NOM_ENS { get; set; }
        public string TYPE_ENS { get; set; }
        public Nullable<System.DateTime> DATE_REC { get; set; }
        public string NIVEAU { get; set; }
        public Nullable<System.DateTime> DATE_SAISIE { get; set; }
        public Nullable<System.DateTime> DATE_DERN_MODIF { get; set; }
        public string ETAT { get; set; }
        public string OBSERVATION { get; set; }
        public string PWD_ENS { get; set; }
        public string PRENOM_ENS { get; set; }
        public Nullable<int> CIN { get; set; }
        public string SEXE_ENS { get; set; }
        public string ETAT_CIVIL_ENS { get; set; }
        public string TEL1 { get; set; }
        public string TEL2 { get; set; }
        public string CNSS_ENS { get; set; }
        public Nullable<System.DateTime> DN_ENS { get; set; }
        public Nullable<System.DateTime> DE_ENS { get; set; }
        public Nullable<System.DateTime> DS_ENS { get; set; }
        public byte[] IMAGE { get; set; }
        public Nullable<int> CHEFCOMITE { get; set; }
        public Nullable<int> COMITE_ID_GRP { get; set; }
        public Nullable<int> FK_CMT { get; set; }
        public string TYPE_UP { get; set; }
        public string UP { get; set; }
        public Nullable<System.DateTime> DATE_DEB_UP { get; set; }
        public string MAIL_ENS { get; set; }
        public string CODE_GRADE_ENTREE { get; set; }
        public string LIB_GRADE_ENTREE { get; set; }
        public string CODE_GRADE_ACTUEL { get; set; }
        public string LIB_GRADE_ACTUELLE { get; set; }
        public string ORGANISME { get; set; }
        public string PWD_INIT { get; set; }
        public string CODE_DEPT { get; set; }
        public string CHEF_DEPT { get; set; }
        public string CODE_ENS_EDUSERV { get; set; }
        public string NOM { get; set; }
        public string PNOM { get; set; }
        public string CODE_MAT { get; set; }
        public byte[] PHOTO2 { get; set; }
        public string DIPLOME { get; set; }
        public string EDE_ROLE { get; set; }
        public string COORDINATEUR_OPTS { get; set; }
        public string CODE_OPTION { get; set; }
        public string RESP_PI { get; set; }
        public string RESP_STAGE { get; set; }
        public string CODE_PI { get; set; }
        public string CODE_STAGE { get; set; }
        public Nullable<System.DateTime> DATE_MODIFY_JWT_PWD { get; set; }
        public string PWD_JWT_ENSEIGNANT { get; set; }
        public string ETAT_FROM_PE { get; set; }
    }
}
