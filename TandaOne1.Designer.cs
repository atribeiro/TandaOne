﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace TandaOne
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EmplSampleEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EmplSampleEntities object using the connection string found in the 'EmplSampleEntities' section of the application configuration file.
        /// </summary>
        public EmplSampleEntities() : base("name=EmplSampleEntities", "EmplSampleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmplSampleEntities object.
        /// </summary>
        public EmplSampleEntities(string connectionString) : base(connectionString, "EmplSampleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EmplSampleEntities object.
        /// </summary>
        public EmplSampleEntities(EntityConnection connection) : base(connection, "EmplSampleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EmployeeDetail> EmployeeDetails
        {
            get
            {
                if ((_EmployeeDetails == null))
                {
                    _EmployeeDetails = base.CreateObjectSet<EmployeeDetail>("EmployeeDetails");
                }
                return _EmployeeDetails;
            }
        }
        private ObjectSet<EmployeeDetail> _EmployeeDetails;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<trackinghour> trackinghours
        {
            get
            {
                if ((_trackinghours == null))
                {
                    _trackinghours = base.CreateObjectSet<trackinghour>("trackinghours");
                }
                return _trackinghours;
            }
        }
        private ObjectSet<trackinghour> _trackinghours;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EmployeeDetails EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmployeeDetails(EmployeeDetail employeeDetail)
        {
            base.AddObject("EmployeeDetails", employeeDetail);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the trackinghours EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotrackinghours(trackinghour trackinghour)
        {
            base.AddObject("trackinghours", trackinghour);
        }

        #endregion


        internal System.Collections.Generic.IEnumerable<EmployeeDetail> ExecuteQuery<T1>(string p)
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmplSampleModel", Name="EmployeeDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EmployeeDetail : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EmployeeDetail object.
        /// </summary>
        /// <param name="employeeID">Initial value of the EmployeeID property.</param>
        public static EmployeeDetail CreateEmployeeDetail(global::System.Int32 employeeID)
        {
            EmployeeDetail employeeDetail = new EmployeeDetail();
            employeeDetail.EmployeeID = employeeID;
            return employeeDetail;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                if (_EmployeeID != value)
                {
                    OnEmployeeIDChanging(value);
                    ReportPropertyChanging("EmployeeID");
                    _EmployeeID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmployeeID");
                    OnEmployeeIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeID;
        partial void OnEmployeeIDChanging(global::System.Int32 value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Surname
        {
            get
            {
                return _Surname;
            }
            set
            {
                OnSurnameChanging(value);
                ReportPropertyChanging("Surname");
                _Surname = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Surname");
                OnSurnameChanged();
            }
        }
        private global::System.String _Surname;
        partial void OnSurnameChanging(global::System.String value);
        partial void OnSurnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private Nullable<global::System.Decimal> _Phone;
        partial void OnPhoneChanging(Nullable<global::System.Decimal> value);
        partial void OnPhoneChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EmplSampleModel", Name="trackinghour")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class trackinghour : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new trackinghour object.
        /// </summary>
        /// <param name="employeeID">Initial value of the EmployeeID property.</param>
        public static trackinghour Createtrackinghour(global::System.Int32 employeeID)
        {
            trackinghour trackinghour = new trackinghour();
            trackinghour.EmployeeID = employeeID;
            return trackinghour;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                if (_EmployeeID != value)
                {
                    OnEmployeeIDChanging(value);
                    ReportPropertyChanging("EmployeeID");
                    _EmployeeID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmployeeID");
                    OnEmployeeIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeID;
        partial void OnEmployeeIDChanging(global::System.Int32 value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Surname
        {
            get
            {
                return _Surname;
            }
            set
            {
                OnSurnameChanging(value);
                ReportPropertyChanging("Surname");
                _Surname = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Surname");
                OnSurnameChanged();
            }
        }
        private global::System.String _Surname;
        partial void OnSurnameChanging(global::System.String value);
        partial void OnSurnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Arrival
        {
            get
            {
                return _Arrival;
            }
            set
            {
                OnArrivalChanging(value);
                ReportPropertyChanging("Arrival");
                _Arrival = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Arrival");
                OnArrivalChanged();
            }
        }
        private Nullable<global::System.DateTime> _Arrival;
        partial void OnArrivalChanging(Nullable<global::System.DateTime> value);
        partial void OnArrivalChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Departure
        {
            get
            {
                return _Departure;
            }
            set
            {
                OnDepartureChanging(value);
                ReportPropertyChanging("Departure");
                _Departure = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Departure");
                OnDepartureChanged();
            }
        }
        private Nullable<global::System.DateTime> _Departure;
        partial void OnDepartureChanging(Nullable<global::System.DateTime> value);
        partial void OnDepartureChanged();

        #endregion

    
    }

    #endregion

    
}