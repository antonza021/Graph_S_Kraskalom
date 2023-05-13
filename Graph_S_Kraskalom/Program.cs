using Graph_S_Kraskalom;

public class Program
{
    public static void Main()
    {
        int vertices = 6;
        Graph graph = new Graph(vertices);
        AdjacencyMatrix adjacencyMatrix = new AdjacencyMatrix(vertices);

        // Добавляем ребра в граф и таблицу смежности
        graph.AddEdge(0, 1, 4);
        adjacencyMatrix.AddEdge(0, 1, 4);

        graph.AddEdge(0, 2, 3);
        adjacencyMatrix.AddEdge(0, 2, 3);

        graph.AddEdge(1, 2, 1);
        adjacencyMatrix.AddEdge(1, 2, 1);

        graph.AddEdge(1, 3, 2);
        adjacencyMatrix.AddEdge(1, 3, 2);

        graph.AddEdge(2, 3, 4);
        adjacencyMatrix.AddEdge(2, 3, 4);

        graph.AddEdge(3, 4, 2);
        adjacencyMatrix.AddEdge(3, 4, 2);

        graph.AddEdge(4, 5, 6);
        adjacencyMatrix.AddEdge(4, 5, 6);

        // Выводим таблицу смежности
        adjacencyMatrix.PrintAdjacencyMatrix();

        // Находим минимальное остовное дерево с помощью алгоритма Краскала
        graph.KruskalMST();
    }
}
