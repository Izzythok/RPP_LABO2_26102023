namespace Entidades2023
{
    public enum EPropulsion {Combustion, Hibrida, Electrica}
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        protected Vehiculo(EPropulsion propulsion)
        {
            this.propulsion = propulsion;
            this.numeroDeChasis = Guid.NewGuid();
            this.esAWD = false;
        }

        protected Vehiculo(bool esAWD, EPropulsion propulsion): this(propulsion)
        {
            this.esAWD = esAWD;
        }

        public EPropulsion Propulsion 
        {
            get
            {
                return this.propulsion;
            }
        }

        protected abstract string Tipo { get; }

        protected virtual string GetInfo()
        {
            return string.Format("{0} {1} {2} {3}",Tipo,this.propulsion,this.esAWD,this.numeroDeChasis);
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.GetType() == v2.GetType() && v1.numeroDeChasis == v2.numeroDeChasis;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return this.GetInfo();
        }
    }
}