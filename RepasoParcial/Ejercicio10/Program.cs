// See https://aka.ms/new-console-template for more information
Persona persona = new Persona();
persona.Edad = 12;
Console.WriteLine($"Edad persona: {persona.Edad}");


public class Persona() {
    private int m_edad;
    public int Edad { get { return m_edad; } 
        set { if (value > 0 && value <= 100)
                m_edad = value;
            else
                Console.WriteLine("Edad no valida, debe estar entre 1 y 100");
        } }
}