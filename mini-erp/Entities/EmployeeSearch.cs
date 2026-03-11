namespace mini_erp.Entities
{
    public class EmployeeSearch
    {
        public string Option { get; set; } = "";
        public string Input { get; set; } = "";
        public EmployeeSearch(string op, string inp)
        {
            Option = op;
            Input = inp;
        }
        public string getOption()
        {
            return Option;
        }
        public string getInput()
        {
            return Input;
        }
    }
}
