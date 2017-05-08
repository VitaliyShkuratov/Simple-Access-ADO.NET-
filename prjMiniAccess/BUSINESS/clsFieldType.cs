namespace prjMiniAccess.BUSINESS
{
    public class clsFieldType
    {
        private string fieldName;
        private object dataType;
        private bool indexed;

        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }
        public object DataType
        {
            get { return dataType; }
            set { dataType = value; }
        }
        public bool Indexed
        {
            get { return indexed; }
            set { indexed = value; }
        }

        public clsFieldType()
        {
            this.fieldName = "unknown";
            this.dataType = null;
            this.indexed = false;
        }
        public clsFieldType(string _fieldName,
                            object _dataType,
                            bool _indexed)
        {
            this.fieldName = _fieldName;
            this.dataType = _dataType;
            this.indexed = _indexed;
        }
    }
}
