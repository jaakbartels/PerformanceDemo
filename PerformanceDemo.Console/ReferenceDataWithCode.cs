namespace PerformanceDemo
{
    public class ReferenceDataWithCode
    {
        protected ReferenceDataWithCode(string code)
        {
            Code = code;
        }

        public string Code { get; }


        protected bool Equals(ReferenceDataWithCode other)
        {
            return Code == ((ReferenceDataWithCode) other).Code;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ReferenceDataWithCode)obj);
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public static bool operator ==(ReferenceDataWithCode a, ReferenceDataWithCode b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(ReferenceDataWithCode a, ReferenceDataWithCode b)
        {
            return !(a == b);
        }

    }
}