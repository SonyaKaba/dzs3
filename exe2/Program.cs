Console.Write("enter point 1 coordinates: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int [] point1 = new int[] {x1,y1,z1};

Console.Write("enter point 2 coordinates: ");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
int [] point2 = new int[] {x2,y2,z2};


double result = Math.Sqrt(Math.Pow (point1[0] - point2[0],2) + Math.Pow (point1[1] - point2[1],2) + Math.Pow (point1[2] - point2[2],2));

Console.WriteLine($"Result is {result}");