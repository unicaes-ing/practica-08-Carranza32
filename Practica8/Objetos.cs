namespace Practica8
{
    public struct Estudiante
    {
        public string carnet;
        public string nombre;
        public string carrera;
        private double cum;

        public void setCum(double cum)
        {
            this.cum = cum;
        }
        
        public double getCum()
        {
            return this.cum;
        }
    }


    public struct Producto
    {
        public string nombre;
        private int cantidad;
        private double precio;

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public int getCantidad()
        {
            return this.cantidad;
        }
        public void setPrecio(double precio)
        {
            this.precio = precio;
        }
        public double getPrecio()
        {
            double iva;
            double total;
            iva = this.precio * 0.13;
            total = (this.precio + iva) * this.cantidad ;
            return total;
        }

    }


    public struct Materia
    {
        public string nombre;
        private double nota;

        public void setNota(double nota)
        {
            this.nota = nota;
        }
        public double getNota()
        {
            return this.nota;
        }
        public string resultado()
        {
            return "aprovado";
        }

    }

    public struct Alumno
    {
        public string carnet;
        public string nombre;
        public string carrera;
        public Materia materia1;
        public Materia materia2;
        public Materia materia3;
        public Materia materia4;
    }
}
