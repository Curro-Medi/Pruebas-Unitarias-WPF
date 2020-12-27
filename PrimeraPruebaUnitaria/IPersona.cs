namespace PrimeraPruebaUnitaria
{
    public interface IPersona
    {
        void conseguirPareja(IPersona p);
        void copiaPersona(IPersona p1);
        void dejarPareja(IPersona p);
        string getApellido();
        int getEdad();
        int getKmRecorridos();
        string getNombre();
        Persona getPareja();
        void morir();
        void nacer();
        bool getVivo();
        string nombreCompleto();
        int salirACorrer(int km);
        void setApellido(string a);
        void setEdad(int e);
        void setNombre(string n);
    }
}