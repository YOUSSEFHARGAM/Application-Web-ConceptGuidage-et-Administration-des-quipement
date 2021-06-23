//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace DAL
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(Condidat))]
    public partial class Entretien
    {
        #region Primitive Properties
        [DataMember]
        public virtual int IdEntretien
        {
            get;
            set;
        }
        [DataMember]
        public virtual int CIN
        {
            get { return _cIN; }
            set
            {
                if (_cIN != value)
                {
                    if (Condidat != null && Condidat.CIN != value)
                    {
                        Condidat = null;
                    }
                    _cIN = value;
                }
            }
        }
        private int _cIN;
        [DataMember]
        public virtual Nullable<bool> DateEntretien
        {
            get;
            set;
        }
        [DataMember]
        public virtual Nullable<int> Description
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
        
    
        [DataMember]
        public virtual Condidat Condidat
        {
            get { return _condidat; }
            set
            {
                if (!ReferenceEquals(_condidat, value))
                {
                    var previousValue = _condidat;
                    _condidat = value;
                    FixupCondidat(previousValue);
                }
            }
        }
        private Condidat _condidat;

        #endregion
        #region Association Fixup
    
        private void FixupCondidat(Condidat previousValue)
        {
            if (previousValue != null && previousValue.Entretien.Contains(this))
            {
                previousValue.Entretien.Remove(this);
            }
    
            if (Condidat != null)
            {
                if (!Condidat.Entretien.Contains(this))
                {
                    Condidat.Entretien.Add(this);
                }
                if (CIN != Condidat.CIN)
                {
                    CIN = Condidat.CIN;
                }
            }
        }

        #endregion
    }
}