class Program
{
    static void Main(string[] args)
    {
        Assignment asmt1 = new Assignment("Suzy Noble", "Fractions");
        Console.WriteLine(asmt1.GetSummary());

        MathAssignment asmt2 = new MathAssignment("Andrew Charles", "Fractions", "Section 9.1", "1-30 odd");
        Console.WriteLine(asmt2.GetSummary());
        Console.WriteLine(asmt2.GetHomeworkList());

        WritingAssignment asmt3 = new WritingAssignment("Vallen Anthony", "Weather", "Weather In the Plains");
        Console.WriteLine(asmt3.GetSummary());
        Console.WriteLine(asmt3.GetWritingInfo());
    }
}