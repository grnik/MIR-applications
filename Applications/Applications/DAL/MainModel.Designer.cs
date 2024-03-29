﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region Метаданные связи EDM

[assembly: EdmRelationshipAttribute("ApplicationsModel", "FK_Applications_Employees", "Employees", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(ApplicationsMir.DAL.Employees), "Applications", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ApplicationsMir.DAL.Applications), true)]
[assembly: EdmRelationshipAttribute("ApplicationsModel", "FK_Applications_Status", "Status", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ApplicationsMir.DAL.Status), "Applications", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ApplicationsMir.DAL.Applications), true)]

#endregion

namespace ApplicationsMir.DAL
{
    #region Контексты
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    public partial class ApplicationsEntities : ObjectContext
    {
        #region Конструкторы
    
        /// <summary>
        /// Инициализирует новый объект ApplicationsEntities, используя строку соединения из раздела "ApplicationsEntities" файла конфигурации приложения.
        /// </summary>
        public ApplicationsEntities() : base("name=ApplicationsEntities", "ApplicationsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта ApplicationsEntities.
        /// </summary>
        public ApplicationsEntities(string connectionString) : base(connectionString, "ApplicationsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта ApplicationsEntities.
        /// </summary>
        public ApplicationsEntities(EntityConnection connection) : base(connection, "ApplicationsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Разделяемые методы
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Свойства ObjectSet
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<Applications> Applications
        {
            get
            {
                if ((_Applications == null))
                {
                    _Applications = base.CreateObjectSet<Applications>("Applications");
                }
                return _Applications;
            }
        }
        private ObjectSet<Applications> _Applications;
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<Employees> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<Employees>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<Employees> _Employees;
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<Status> Status
        {
            get
            {
                if ((_Status == null))
                {
                    _Status = base.CreateObjectSet<Status>("Status");
                }
                return _Status;
            }
        }
        private ObjectSet<Status> _Status;

        #endregion
        #region Методы AddTo
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet Applications. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToApplications(Applications applications)
        {
            base.AddObject("Applications", applications);
        }
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet Employees. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToEmployees(Employees employees)
        {
            base.AddObject("Employees", employees);
        }
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet Status. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToStatus(Status status)
        {
            base.AddObject("Status", status);
        }

        #endregion
    }
    

    #endregion
    
    #region Сущности
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityType(NamespaceName="ApplicationsModel", Name="Applications")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Applications : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта Applications.
        /// </summary>
        /// <param name="id">Исходное значение свойства ID.</param>
        /// <param name="creating">Исходное значение свойства Creating.</param>
        /// <param name="who">Исходное значение свойства Who.</param>
        /// <param name="login">Исходное значение свойства Login.</param>
        /// <param name="description">Исходное значение свойства Description.</param>
        /// <param name="problem">Исходное значение свойства Problem.</param>
        /// <param name="statusID">Исходное значение свойства StatusID.</param>
        public static Applications CreateApplications(global::System.Int32 id, global::System.DateTime creating, global::System.String who, global::System.String login, global::System.String description, global::System.String problem, global::System.Int32 statusID)
        {
            Applications applications = new Applications();
            applications.ID = id;
            applications.Creating = creating;
            applications.Who = who;
            applications.Login = login;
            applications.Description = description;
            applications.Problem = problem;
            applications.StatusID = statusID;
            return applications;
        }

        #endregion
        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.DateTime Creating
        {
            get
            {
                return _Creating;
            }
            private set
            {
                OnCreatingChanging(value);
                ReportPropertyChanging("Creating");
                _Creating = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Creating");
                OnCreatingChanged();
            }
        }
        private global::System.DateTime _Creating;
        partial void OnCreatingChanging(global::System.DateTime value);
        partial void OnCreatingChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Who
        {
            get
            {
                return _Who;
            }
            set
            {
                OnWhoChanging(value);
                ReportPropertyChanging("Who");
                _Who = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Who");
                OnWhoChanged();
            }
        }
        private global::System.String _Who;
        partial void OnWhoChanging(global::System.String value);
        partial void OnWhoChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Int32> Room
        {
            get
            {
                return _Room;
            }
            set
            {
                OnRoomChanging(value);
                ReportPropertyChanging("Room");
                _Room = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Room");
                OnRoomChanged();
            }
        }
        private Nullable<global::System.Int32> _Room;
        partial void OnRoomChanging(Nullable<global::System.Int32> value);
        partial void OnRoomChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Login
        {
            get
            {
                return _Login;
            }
            private set
            {
                OnLoginChanging(value);
                ReportPropertyChanging("Login");
                _Login = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Login");
                OnLoginChanged();
            }
        }
        private global::System.String _Login;
        partial void OnLoginChanging(global::System.String value);
        partial void OnLoginChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Int32> EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                OnEmployeeIDChanging(value);
                ReportPropertyChanging("EmployeeID");
                _EmployeeID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EmployeeID");
                OnEmployeeIDChanged();
            }
        }
        private Nullable<global::System.Int32> _EmployeeID;
        partial void OnEmployeeIDChanging(Nullable<global::System.Int32> value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Problem
        {
            get
            {
                return _Problem;
            }
            set
            {
                OnProblemChanging(value);
                ReportPropertyChanging("Problem");
                _Problem = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Problem");
                OnProblemChanged();
            }
        }
        private global::System.String _Problem;
        partial void OnProblemChanging(global::System.String value);
        partial void OnProblemChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 StatusID
        {
            get
            {
                return _StatusID;
            }
            set
            {
                OnStatusIDChanging(value);
                ReportPropertyChanging("StatusID");
                _StatusID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StatusID");
                OnStatusIDChanged();
            }
        }
        private global::System.Int32 _StatusID;
        partial void OnStatusIDChanging(global::System.Int32 value);
        partial void OnStatusIDChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public global::System.String Comment
        {
            get
            {
                return _Comment;
            }
            set
            {
                OnCommentChanging(value);
                ReportPropertyChanging("Comment");
                _Comment = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Comment");
                OnCommentChanged();
            }
        }
        private global::System.String _Comment;
        partial void OnCommentChanging(global::System.String value);
        partial void OnCommentChanged();

        #endregion
    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("ApplicationsModel", "FK_Applications_Employees", "Employees")]
        public Employees Employees
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employees>("ApplicationsModel.FK_Applications_Employees", "Employees").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employees>("ApplicationsModel.FK_Applications_Employees", "Employees").Value = value;
            }
        }
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Employees> EmployeesReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Employees>("ApplicationsModel.FK_Applications_Employees", "Employees");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Employees>("ApplicationsModel.FK_Applications_Employees", "Employees", value);
                }
            }
        }
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("ApplicationsModel", "FK_Applications_Status", "Status")]
        public Status Status
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Status>("ApplicationsModel.FK_Applications_Status", "Status").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Status>("ApplicationsModel.FK_Applications_Status", "Status").Value = value;
            }
        }
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<Status> StatusReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Status>("ApplicationsModel.FK_Applications_Status", "Status");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Status>("ApplicationsModel.FK_Applications_Status", "Status", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityType(NamespaceName="ApplicationsModel", Name="Employees")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Employees : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта Employees.
        /// </summary>
        /// <param name="id">Исходное значение свойства ID.</param>
        /// <param name="name">Исходное значение свойства Name.</param>
        public static Employees CreateEmployees(global::System.Int32 id, global::System.String name)
        {
            Employees employees = new Employees();
            employees.ID = id;
            employees.Name = name;
            return employees;
        }

        #endregion
        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("ApplicationsModel", "FK_Applications_Employees", "Applications")]
        public EntityCollection<Applications> Applications
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Applications>("ApplicationsModel.FK_Applications_Employees", "Applications");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Applications>("ApplicationsModel.FK_Applications_Employees", "Applications", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityType(NamespaceName="ApplicationsModel", Name="Status")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class Status : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта Status.
        /// </summary>
        /// <param name="id">Исходное значение свойства ID.</param>
        /// <param name="name">Исходное значение свойства Name.</param>
        public static Status CreateStatus(global::System.Int32 id, global::System.String name)
        {
            Status status = new Status();
            status.ID = id;
            status.Name = name;
            return status;
        }

        #endregion
        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("ApplicationsModel", "FK_Applications_Status", "Applications")]
        public EntityCollection<Applications> Applications
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Applications>("ApplicationsModel.FK_Applications_Status", "Applications");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Applications>("ApplicationsModel.FK_Applications_Status", "Applications", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
