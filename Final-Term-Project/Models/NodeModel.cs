namespace Final_Term_Project.Models
{
    public class NodeModel<T>
    {
        public T Data { get; set; }
        public NodeModel<T> Next { get; set; }

        public NodeModel(T data)
        {
            Data = data;
            Next = null;
        }
    }
}