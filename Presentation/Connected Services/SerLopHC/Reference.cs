﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentation.SerLopHC {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DTLophanhchinh", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class DTLophanhchinh : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaLopHanhChinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenLopHanhChinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaGiangVienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenGiangVienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaKhoaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenKhoaField;
        
        private int NamNhapHocField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MaLopHanhChinh {
            get {
                return this.MaLopHanhChinhField;
            }
            set {
                if ((object.ReferenceEquals(this.MaLopHanhChinhField, value) != true)) {
                    this.MaLopHanhChinhField = value;
                    this.RaisePropertyChanged("MaLopHanhChinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string TenLopHanhChinh {
            get {
                return this.TenLopHanhChinhField;
            }
            set {
                if ((object.ReferenceEquals(this.TenLopHanhChinhField, value) != true)) {
                    this.TenLopHanhChinhField = value;
                    this.RaisePropertyChanged("TenLopHanhChinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string MaGiangVien {
            get {
                return this.MaGiangVienField;
            }
            set {
                if ((object.ReferenceEquals(this.MaGiangVienField, value) != true)) {
                    this.MaGiangVienField = value;
                    this.RaisePropertyChanged("MaGiangVien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string TenGiangVien {
            get {
                return this.TenGiangVienField;
            }
            set {
                if ((object.ReferenceEquals(this.TenGiangVienField, value) != true)) {
                    this.TenGiangVienField = value;
                    this.RaisePropertyChanged("TenGiangVien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string MaKhoa {
            get {
                return this.MaKhoaField;
            }
            set {
                if ((object.ReferenceEquals(this.MaKhoaField, value) != true)) {
                    this.MaKhoaField = value;
                    this.RaisePropertyChanged("MaKhoa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string TenKhoa {
            get {
                return this.TenKhoaField;
            }
            set {
                if ((object.ReferenceEquals(this.TenKhoaField, value) != true)) {
                    this.TenKhoaField = value;
                    this.RaisePropertyChanged("TenKhoa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int NamNhapHoc {
            get {
                return this.NamNhapHocField;
            }
            set {
                if ((this.NamNhapHocField.Equals(value) != true)) {
                    this.NamNhapHocField = value;
                    this.RaisePropertyChanged("NamNhapHoc");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DTGiangvien", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class DTGiangvien : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaGiangVienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenGiangVienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HoDemField;
        
        private bool GioiTinhField;
        
        private System.DateTime NgaySinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiaChiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DienThoaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HocViField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaKhoaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenKhoaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MaGiangVien {
            get {
                return this.MaGiangVienField;
            }
            set {
                if ((object.ReferenceEquals(this.MaGiangVienField, value) != true)) {
                    this.MaGiangVienField = value;
                    this.RaisePropertyChanged("MaGiangVien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string TenGiangVien {
            get {
                return this.TenGiangVienField;
            }
            set {
                if ((object.ReferenceEquals(this.TenGiangVienField, value) != true)) {
                    this.TenGiangVienField = value;
                    this.RaisePropertyChanged("TenGiangVien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string HoDem {
            get {
                return this.HoDemField;
            }
            set {
                if ((object.ReferenceEquals(this.HoDemField, value) != true)) {
                    this.HoDemField = value;
                    this.RaisePropertyChanged("HoDem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public bool GioiTinh {
            get {
                return this.GioiTinhField;
            }
            set {
                if ((this.GioiTinhField.Equals(value) != true)) {
                    this.GioiTinhField = value;
                    this.RaisePropertyChanged("GioiTinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.DateTime NgaySinh {
            get {
                return this.NgaySinhField;
            }
            set {
                if ((this.NgaySinhField.Equals(value) != true)) {
                    this.NgaySinhField = value;
                    this.RaisePropertyChanged("NgaySinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string DiaChi {
            get {
                return this.DiaChiField;
            }
            set {
                if ((object.ReferenceEquals(this.DiaChiField, value) != true)) {
                    this.DiaChiField = value;
                    this.RaisePropertyChanged("DiaChi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string DienThoai {
            get {
                return this.DienThoaiField;
            }
            set {
                if ((object.ReferenceEquals(this.DienThoaiField, value) != true)) {
                    this.DienThoaiField = value;
                    this.RaisePropertyChanged("DienThoai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string HocVi {
            get {
                return this.HocViField;
            }
            set {
                if ((object.ReferenceEquals(this.HocViField, value) != true)) {
                    this.HocViField = value;
                    this.RaisePropertyChanged("HocVi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string MaKhoa {
            get {
                return this.MaKhoaField;
            }
            set {
                if ((object.ReferenceEquals(this.MaKhoaField, value) != true)) {
                    this.MaKhoaField = value;
                    this.RaisePropertyChanged("MaKhoa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string TenKhoa {
            get {
                return this.TenKhoaField;
            }
            set {
                if ((object.ReferenceEquals(this.TenKhoaField, value) != true)) {
                    this.TenKhoaField = value;
                    this.RaisePropertyChanged("TenKhoa");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SerLopHC.SerLopHCSoap")]
    public interface SerLopHCSoap {
        
        // CODEGEN: Generating message contract since element name GetAllLHCResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllLHC", ReplyAction="*")]
        Presentation.SerLopHC.GetAllLHCResponse GetAllLHC(Presentation.SerLopHC.GetAllLHCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllLHC", ReplyAction="*")]
        System.Threading.Tasks.Task<Presentation.SerLopHC.GetAllLHCResponse> GetAllLHCAsync(Presentation.SerLopHC.GetAllLHCRequest request);
        
        // CODEGEN: Generating message contract since element name GetGVCNResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGVCN", ReplyAction="*")]
        Presentation.SerLopHC.GetGVCNResponse GetGVCN(Presentation.SerLopHC.GetGVCNRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGVCN", ReplyAction="*")]
        System.Threading.Tasks.Task<Presentation.SerLopHC.GetGVCNResponse> GetGVCNAsync(Presentation.SerLopHC.GetGVCNRequest request);
        
        // CODEGEN: Generating message contract since element name lop from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddLHC", ReplyAction="*")]
        Presentation.SerLopHC.AddLHCResponse AddLHC(Presentation.SerLopHC.AddLHCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddLHC", ReplyAction="*")]
        System.Threading.Tasks.Task<Presentation.SerLopHC.AddLHCResponse> AddLHCAsync(Presentation.SerLopHC.AddLHCRequest request);
        
        // CODEGEN: Generating message contract since element name lop from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EditLHC", ReplyAction="*")]
        Presentation.SerLopHC.EditLHCResponse EditLHC(Presentation.SerLopHC.EditLHCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EditLHC", ReplyAction="*")]
        System.Threading.Tasks.Task<Presentation.SerLopHC.EditLHCResponse> EditLHCAsync(Presentation.SerLopHC.EditLHCRequest request);
        
        // CODEGEN: Generating message contract since element name ma from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DelteLHC", ReplyAction="*")]
        Presentation.SerLopHC.DelteLHCResponse DelteLHC(Presentation.SerLopHC.DelteLHCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DelteLHC", ReplyAction="*")]
        System.Threading.Tasks.Task<Presentation.SerLopHC.DelteLHCResponse> DelteLHCAsync(Presentation.SerLopHC.DelteLHCRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllLHCRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllLHC", Namespace="http://tempuri.org/", Order=0)]
        public Presentation.SerLopHC.GetAllLHCRequestBody Body;
        
        public GetAllLHCRequest() {
        }
        
        public GetAllLHCRequest(Presentation.SerLopHC.GetAllLHCRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllLHCRequestBody {
        
        public GetAllLHCRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllLHCResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllLHCResponse", Namespace="http://tempuri.org/", Order=0)]
        public Presentation.SerLopHC.GetAllLHCResponseBody Body;
        
        public GetAllLHCResponse() {
        }
        
        public GetAllLHCResponse(Presentation.SerLopHC.GetAllLHCResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllLHCResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Presentation.SerLopHC.DTLophanhchinh[] GetAllLHCResult;
        
        public GetAllLHCResponseBody() {
        }
        
        public GetAllLHCResponseBody(Presentation.SerLopHC.DTLophanhchinh[] GetAllLHCResult) {
            this.GetAllLHCResult = GetAllLHCResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGVCNRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGVCN", Namespace="http://tempuri.org/", Order=0)]
        public Presentation.SerLopHC.GetGVCNRequestBody Body;
        
        public GetGVCNRequest() {
        }
        
        public GetGVCNRequest(Presentation.SerLopHC.GetGVCNRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetGVCNRequestBody {
        
        public GetGVCNRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGVCNResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGVCNResponse", Namespace="http://tempuri.org/", Order=0)]
        public Presentation.SerLopHC.GetGVCNResponseBody Body;
        
        public GetGVCNResponse() {
        }
        
        public GetGVCNResponse(Presentation.SerLopHC.GetGVCNResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGVCNResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Presentation.SerLopHC.DTGiangvien[] GetGVCNResult;
        
        public GetGVCNResponseBody() {
        }
        
        public GetGVCNResponseBody(Presentation.SerLopHC.DTGiangvien[] GetGVCNResult) {
            this.GetGVCNResult = GetGVCNResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddLHCRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddLHC", Namespace="http://tempuri.org/", Order=0)]
        public Presentation.SerLopHC.AddLHCRequestBody Body;
        
        public AddLHCRequest() {
        }
        
        public AddLHCRequest(Presentation.SerLopHC.AddLHCRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddLHCRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Presentation.SerLopHC.DTLophanhchinh lop;
        
        public AddLHCRequestBody() {
        }
        
        public AddLHCRequestBody(Presentation.SerLopHC.DTLophanhchinh lop) {
            this.lop = lop;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddLHCResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddLHCResponse", Namespace="http://tempuri.org/", Order=0)]
        public Presentation.SerLopHC.AddLHCResponseBody Body;
        
        public AddLHCResponse() {
        }
        
        public AddLHCResponse(Presentation.SerLopHC.AddLHCResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddLHCResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AddLHCResult;
        
        public AddLHCResponseBody() {
        }
        
        public AddLHCResponseBody(bool AddLHCResult) {
            this.AddLHCResult = AddLHCResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EditLHCRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EditLHC", Namespace="http://tempuri.org/", Order=0)]
        public Presentation.SerLopHC.EditLHCRequestBody Body;
        
        public EditLHCRequest() {
        }
        
        public EditLHCRequest(Presentation.SerLopHC.EditLHCRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EditLHCRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Presentation.SerLopHC.DTLophanhchinh lop;
        
        public EditLHCRequestBody() {
        }
        
        public EditLHCRequestBody(Presentation.SerLopHC.DTLophanhchinh lop) {
            this.lop = lop;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EditLHCResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EditLHCResponse", Namespace="http://tempuri.org/", Order=0)]
        public Presentation.SerLopHC.EditLHCResponseBody Body;
        
        public EditLHCResponse() {
        }
        
        public EditLHCResponse(Presentation.SerLopHC.EditLHCResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EditLHCResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool EditLHCResult;
        
        public EditLHCResponseBody() {
        }
        
        public EditLHCResponseBody(bool EditLHCResult) {
            this.EditLHCResult = EditLHCResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DelteLHCRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DelteLHC", Namespace="http://tempuri.org/", Order=0)]
        public Presentation.SerLopHC.DelteLHCRequestBody Body;
        
        public DelteLHCRequest() {
        }
        
        public DelteLHCRequest(Presentation.SerLopHC.DelteLHCRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DelteLHCRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ma;
        
        public DelteLHCRequestBody() {
        }
        
        public DelteLHCRequestBody(string ma) {
            this.ma = ma;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DelteLHCResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DelteLHCResponse", Namespace="http://tempuri.org/", Order=0)]
        public Presentation.SerLopHC.DelteLHCResponseBody Body;
        
        public DelteLHCResponse() {
        }
        
        public DelteLHCResponse(Presentation.SerLopHC.DelteLHCResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DelteLHCResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool DelteLHCResult;
        
        public DelteLHCResponseBody() {
        }
        
        public DelteLHCResponseBody(bool DelteLHCResult) {
            this.DelteLHCResult = DelteLHCResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SerLopHCSoapChannel : Presentation.SerLopHC.SerLopHCSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SerLopHCSoapClient : System.ServiceModel.ClientBase<Presentation.SerLopHC.SerLopHCSoap>, Presentation.SerLopHC.SerLopHCSoap {
        
        public SerLopHCSoapClient() {
        }
        
        public SerLopHCSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SerLopHCSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SerLopHCSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SerLopHCSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Presentation.SerLopHC.GetAllLHCResponse Presentation.SerLopHC.SerLopHCSoap.GetAllLHC(Presentation.SerLopHC.GetAllLHCRequest request) {
            return base.Channel.GetAllLHC(request);
        }
        
        public Presentation.SerLopHC.DTLophanhchinh[] GetAllLHC() {
            Presentation.SerLopHC.GetAllLHCRequest inValue = new Presentation.SerLopHC.GetAllLHCRequest();
            inValue.Body = new Presentation.SerLopHC.GetAllLHCRequestBody();
            Presentation.SerLopHC.GetAllLHCResponse retVal = ((Presentation.SerLopHC.SerLopHCSoap)(this)).GetAllLHC(inValue);
            return retVal.Body.GetAllLHCResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Presentation.SerLopHC.GetAllLHCResponse> Presentation.SerLopHC.SerLopHCSoap.GetAllLHCAsync(Presentation.SerLopHC.GetAllLHCRequest request) {
            return base.Channel.GetAllLHCAsync(request);
        }
        
        public System.Threading.Tasks.Task<Presentation.SerLopHC.GetAllLHCResponse> GetAllLHCAsync() {
            Presentation.SerLopHC.GetAllLHCRequest inValue = new Presentation.SerLopHC.GetAllLHCRequest();
            inValue.Body = new Presentation.SerLopHC.GetAllLHCRequestBody();
            return ((Presentation.SerLopHC.SerLopHCSoap)(this)).GetAllLHCAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Presentation.SerLopHC.GetGVCNResponse Presentation.SerLopHC.SerLopHCSoap.GetGVCN(Presentation.SerLopHC.GetGVCNRequest request) {
            return base.Channel.GetGVCN(request);
        }
        
        public Presentation.SerLopHC.DTGiangvien[] GetGVCN() {
            Presentation.SerLopHC.GetGVCNRequest inValue = new Presentation.SerLopHC.GetGVCNRequest();
            inValue.Body = new Presentation.SerLopHC.GetGVCNRequestBody();
            Presentation.SerLopHC.GetGVCNResponse retVal = ((Presentation.SerLopHC.SerLopHCSoap)(this)).GetGVCN(inValue);
            return retVal.Body.GetGVCNResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Presentation.SerLopHC.GetGVCNResponse> Presentation.SerLopHC.SerLopHCSoap.GetGVCNAsync(Presentation.SerLopHC.GetGVCNRequest request) {
            return base.Channel.GetGVCNAsync(request);
        }
        
        public System.Threading.Tasks.Task<Presentation.SerLopHC.GetGVCNResponse> GetGVCNAsync() {
            Presentation.SerLopHC.GetGVCNRequest inValue = new Presentation.SerLopHC.GetGVCNRequest();
            inValue.Body = new Presentation.SerLopHC.GetGVCNRequestBody();
            return ((Presentation.SerLopHC.SerLopHCSoap)(this)).GetGVCNAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Presentation.SerLopHC.AddLHCResponse Presentation.SerLopHC.SerLopHCSoap.AddLHC(Presentation.SerLopHC.AddLHCRequest request) {
            return base.Channel.AddLHC(request);
        }
        
        public bool AddLHC(Presentation.SerLopHC.DTLophanhchinh lop) {
            Presentation.SerLopHC.AddLHCRequest inValue = new Presentation.SerLopHC.AddLHCRequest();
            inValue.Body = new Presentation.SerLopHC.AddLHCRequestBody();
            inValue.Body.lop = lop;
            Presentation.SerLopHC.AddLHCResponse retVal = ((Presentation.SerLopHC.SerLopHCSoap)(this)).AddLHC(inValue);
            return retVal.Body.AddLHCResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Presentation.SerLopHC.AddLHCResponse> Presentation.SerLopHC.SerLopHCSoap.AddLHCAsync(Presentation.SerLopHC.AddLHCRequest request) {
            return base.Channel.AddLHCAsync(request);
        }
        
        public System.Threading.Tasks.Task<Presentation.SerLopHC.AddLHCResponse> AddLHCAsync(Presentation.SerLopHC.DTLophanhchinh lop) {
            Presentation.SerLopHC.AddLHCRequest inValue = new Presentation.SerLopHC.AddLHCRequest();
            inValue.Body = new Presentation.SerLopHC.AddLHCRequestBody();
            inValue.Body.lop = lop;
            return ((Presentation.SerLopHC.SerLopHCSoap)(this)).AddLHCAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Presentation.SerLopHC.EditLHCResponse Presentation.SerLopHC.SerLopHCSoap.EditLHC(Presentation.SerLopHC.EditLHCRequest request) {
            return base.Channel.EditLHC(request);
        }
        
        public bool EditLHC(Presentation.SerLopHC.DTLophanhchinh lop) {
            Presentation.SerLopHC.EditLHCRequest inValue = new Presentation.SerLopHC.EditLHCRequest();
            inValue.Body = new Presentation.SerLopHC.EditLHCRequestBody();
            inValue.Body.lop = lop;
            Presentation.SerLopHC.EditLHCResponse retVal = ((Presentation.SerLopHC.SerLopHCSoap)(this)).EditLHC(inValue);
            return retVal.Body.EditLHCResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Presentation.SerLopHC.EditLHCResponse> Presentation.SerLopHC.SerLopHCSoap.EditLHCAsync(Presentation.SerLopHC.EditLHCRequest request) {
            return base.Channel.EditLHCAsync(request);
        }
        
        public System.Threading.Tasks.Task<Presentation.SerLopHC.EditLHCResponse> EditLHCAsync(Presentation.SerLopHC.DTLophanhchinh lop) {
            Presentation.SerLopHC.EditLHCRequest inValue = new Presentation.SerLopHC.EditLHCRequest();
            inValue.Body = new Presentation.SerLopHC.EditLHCRequestBody();
            inValue.Body.lop = lop;
            return ((Presentation.SerLopHC.SerLopHCSoap)(this)).EditLHCAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Presentation.SerLopHC.DelteLHCResponse Presentation.SerLopHC.SerLopHCSoap.DelteLHC(Presentation.SerLopHC.DelteLHCRequest request) {
            return base.Channel.DelteLHC(request);
        }
        
        public bool DelteLHC(string ma) {
            Presentation.SerLopHC.DelteLHCRequest inValue = new Presentation.SerLopHC.DelteLHCRequest();
            inValue.Body = new Presentation.SerLopHC.DelteLHCRequestBody();
            inValue.Body.ma = ma;
            Presentation.SerLopHC.DelteLHCResponse retVal = ((Presentation.SerLopHC.SerLopHCSoap)(this)).DelteLHC(inValue);
            return retVal.Body.DelteLHCResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Presentation.SerLopHC.DelteLHCResponse> Presentation.SerLopHC.SerLopHCSoap.DelteLHCAsync(Presentation.SerLopHC.DelteLHCRequest request) {
            return base.Channel.DelteLHCAsync(request);
        }
        
        public System.Threading.Tasks.Task<Presentation.SerLopHC.DelteLHCResponse> DelteLHCAsync(string ma) {
            Presentation.SerLopHC.DelteLHCRequest inValue = new Presentation.SerLopHC.DelteLHCRequest();
            inValue.Body = new Presentation.SerLopHC.DelteLHCRequestBody();
            inValue.Body.ma = ma;
            return ((Presentation.SerLopHC.SerLopHCSoap)(this)).DelteLHCAsync(inValue);
        }
    }
}