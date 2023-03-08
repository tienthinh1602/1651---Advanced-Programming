
namespace Exam
{
    class Temperature
    {
        private double _ftemp;
        public Temperature()
        {
            this._ftemp = 0;
        }

        public Temperature(double ftemp)
        {
            this._ftemp = ftemp;
        }

        public void setFahrenheit(double ftemp)
        {
            this._ftemp = ftemp;
        }

        public double getFahrenheit()
        {
            return _ftemp;
        }
        public double getCelsius()
        {
            return (this._ftemp-32)*(5.0/9);
        }
        public double getKelvin()
        {
            return getCelsius()+273;
        }
        public override string ToString()
        {
            return "F = " + this.getFahrenheit() + "C = " + this.getCelsius() + "K = " + this.getKelvin();
        }
    }
}