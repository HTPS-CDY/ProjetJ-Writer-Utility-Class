namespace Writer
{
    class Wr
    {
        public static void Write(string file ,string message)
        {
            using (StreamWriter wrt = new StreamWriter(file, true))
            {
                wrt.WriteLine(message);
            }
        }
    }
    class Rea
    {
        public static List<string> Read(string file)
        {
            try
            {
            
            List<string> lines = new List<string>();
            using (StreamReader wrr = new StreamReader(file))
            {
                string? line;
                while ((line = wrr.ReadLine())!= null)
                {
                    lines.Add(line);
                }
                
            }
            return lines;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return new List<string>();
            }
        }
    }
    class Reatxt
    {
        public static void Read(string file)
        {
            try
            {
                using (StreamReader wrr = new StreamReader(file))
                {
                    string? line;
                    while ((line = wrr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }
}