using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace EulerianGraph
{
    public class Eurelian
    {
        /// <summary>
        /// Класс графа
        /// </summary>
        public class Graph
        {
            #region Поля и свойства класса Graph

            /// <summary>
            /// Экземпляр для работы с графикой
            /// </summary>
            public DrawGraph G;

            /// <summary>
            /// Список всех вершин
            /// </summary>
            public List<Vertex> V = new List<Vertex>();

            /// <summary>
            /// Список всех граней
            /// </summary>
            public List<Edge> E = new List<Edge>();

            /// <summary>
            /// Свойство для задания и получения имени файла с введенным графом
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Свойство для задания и получения количества вершин графа
            /// </summary>
            public int NumberOfDots { get; set; }

            /// <summary>
            /// Свойство для задания и получения количества ребер графа
            /// </summary>
            public int NumberOfLine { get; set; }

            /// <summary>
            /// Свойство для задания и получения массива FO 
            /// </summary>
            public List<int> FO = new List<int>();

            /// <summary>
            /// Свойство для задания и получения матрицы смежности графа
            /// </summary>
            public int[,] Matrix { get; set; }

            /// <summary>
            /// Свойство для задания и получения флага-признака того, является ли граф Эйлеровым
            /// </summary>
            public bool IsEulerian { get; set; }

            /// <summary>
            /// Свойство для задания и получения Эйлерового пути
            /// </summary>
            public List<int> Way = new List<int>();
            #endregion

            #region Все методы класса Graph

            /// <summary>
            /// Метод для очистки данных о графе
            /// </summary>
            public void ClearAllData()
            {
                Name = "Данные не введены";
                NumberOfDots = 0;
                NumberOfLine = 0;
                IsEulerian = false;
                E.Clear();
                V.Clear();
                G.clearSheet();
                Way.Clear();
                FO.Clear();
            }

            /// <summary>
            /// Проверка графа на связность с использованием выделения связной компоненты графа
            /// </summary>
            private bool IsConnected()
            {
                int[] VertexState = new int[NumberOfDots];
                bool flag = false;
                int k = 0;
                int finalCount = 0;

                //Пометим все вершины первым маркером - нам про них ничего не известно 
                for (int i = 0; i < NumberOfDots; i++)
                    VertexState[i] = 1;

                //Выберем любую вершину, пометим ее вторым маркером, ведь она может быть достигнута сама из себя. 
                VertexState[0] = 2;

                //Если нет вершин, помеченных вторым маркером - переходим к третьему этапу.
                do
                {
                    flag = true;

                    for (int i = 0; i < NumberOfDots; i++)
                        if (VertexState[i] == 2) //Выберем любую вершину, помеченную вторым маркером.  
                        {
                            VertexState[i] = 3;  //Пометим ее третьим маркером
                            k = i;
                            break;
                        }

                    for (int i = 0; i < NumberOfDots; i++)
                        if (Matrix[k,i] == 1 && VertexState[i] == 1) //Все вершины, соседние с данной и помеченные первым маркером, пометим вторым маркером. 
                            VertexState[i] = 2; 
                                            
                    for (int i = 0; i < NumberOfDots; i++)
                        if (VertexState[i] == 2)
                            flag = false;

                } while (flag == false);

                //Если число вершин, помеченные первым маркером, равно нулю, то граф связный. 
                for (int i = 0; i < NumberOfDots; i++)
                    if (VertexState[i] == 1)
                        finalCount++;

                // Если finalCount = 0, то граф связный
                if (finalCount == 0)
                    return true;
                else
                    return false;

            }

            /// <summary>
            /// Метод для проверки, является ли граф эйлеровым или нет
            /// </summary>
            /// <returns></returns>
            public void EulerianOrNot()
            {
                //Количество вершин нечетной степени
                int OddDots = 0;

                //Проверка количества вершин нечётной степени
                for (int i = 0; i < NumberOfDots; i++)
                {
                    int tmp = 0;
                    for (int j = 0; j < NumberOfDots; j++)
                    
                        if (Matrix[i, j] == 1)
                            tmp++;

                    if (tmp % 2 != 0)
                        OddDots++;
                }
                //Если количество нечетных вершин меньше 2 и граф связный, то приступаем к поиску эйлерова графа
                if (OddDots <= 2 && IsConnected())
                    FindEulerian();
                
                //Если хотя бы одно из условий не соблюдается, то граф не эйлеров
                else
                    IsEulerian = false;
                
            }

            /// <summary>
            /// Метод для поиска Эйлерова пути в графе
            /// </summary>
            private void FindEulerian()
            {
                string result = "";
                List<int> NodeList = new List<int>();

                int[,] tmp = new int[NumberOfDots,NumberOfDots];

                for (int i = 0; i < NumberOfDots; i++)
                {
                    for (int j = 0; j < NumberOfDots; j++)
                    {
                        tmp[i, j] = Matrix[i, j];
                    }
                }

                //Создание списка NodeList и занесение в него всех существующих вершин
                for (int i = 0; i < NumberOfDots; i++)
                    NodeList.Add(i);

                int key = 0;

                ///Определение оптимальной вершины, для поиска
                for (int i = 0; i < NumberOfDots; i++)
                {
                    int N = 0;
                    for (int j = 0; j < NumberOfDots; j++)
                    {
                        if (tmp[i, j] == 1)
                            N++;
                    }
                    if (N % 2 != 0)
                    {
                        key = i;
                        break;
                    }
                }

                //Стек с временным путем
                Stack<int> tempPath = new Stack<int>();

                //Стек с итоговым путем
                Stack<int> finalPath = new Stack<int>();

                int start = NodeList[key];        //Старт с оптимальной вершины
                tempPath.Push(NodeList[key]);     //В стек добавляем стартовую вершину

                //Ищем эйлеров путь
                try
                {
                    while (tempPath.Count != 0)
                    {
                        for (int i = 0; i < NumberOfDots; i++)
                        {
                            if (tmp[start, i] == 1)                  //Проверяем, имеет ли матрица смежности с заданными координатами связь со следующей вершиной
                            {
                                tempPath.Push(NodeList[i]);             //Заносим в стек текущую вершину
                                tmp[start, i] = 0;                   //Удаляем связи текущей вершины со следующей
                                tmp[i, start] = 0;                   //

                                if (!hasNeighbour((int)tempPath.Peek(), tmp)) //Проверяем, имеет ли текущая вершина соседние вершины
                                {                                        //Если не имеет, то достаем все значения из стека в итоговый стек
                                    while (tempPath.Count!= 0 && !hasNeighbour((int)tempPath.Peek(), tmp) )
                                    {
                                        finalPath.Push(tempPath.Pop());  //Добавляем в стек с финальным путем вершины из временного стека
                                    }
                                    start = (int)finalPath.Peek();       //Задаем стартовой вершиной верхний элемент в финальном стеке
                                }
                                else                                     //Если имеет соседние вершины, то переходим по цепочке в соседнюю вершину
                                {
                                    start = i;                           //Задаем стартовой вершиной следующий элемент
                                    break;
                                }
                            }
                        }
                    }

                    //Записываем все элементы из стека в список Way 
                    foreach (int o in finalPath)
                    {
                        result += Convert.ToString(o) + " ";
                        Way.Add(o+1);
                        IsEulerian = true;
                    }
                    NumberOfLine = finalPath.Count - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Исключение: {ex.Message}\n\nМетод: {ex.TargetSite}\n\nТрассировка стека: {ex.StackTrace}", "Возникла ошибка!");
                }
            }

            /// <summary>
            /// Имеет ли текущая вершина соседние вершины (Проверка по матрице смежности)
            /// </summary>
            /// <param name="a">Номер текущей вершины</param>
            /// <param name="tmp">Копия матрицы смежности</param>
            /// <returns></returns>
            private bool hasNeighbour(int a, int[,]tmp)
            {
                for (int i = 0; i < NumberOfDots; i++)
                {
                    if (tmp[a, i] == 1)
                        return true;
                }
                return false;
            }

            /// <summary>
            /// Метод для конвертации ФО представления графа в матрицу смежности
            /// </summary>
            /// <returns></returns>
            public bool ConvertFOtoMatrix()
            {
                try
                {
                    int c = 0;
                    //Подсчет количества 0 (разделителей) в ФО массиве
                    for (int i = 0; i < FO.Count; i++)
                        if (FO[i] == 0)
                            c++;

                    //Вывод сообщения об ошибке при количестве разделителей 0
                    if (c == 0)
                    {
                        MessageBox.Show("FO-представление графа не имеет разделителя (0) или таковой является некорректным", "Ошибка содержимого FO");
                        ClearAllData();
                        return false;
                    }
                    else
                    {
                        c++;
                        NumberOfDots = c; //Количество точек равно количеству разделителей
                        Matrix = new int[c, c];
                        int k = 0;

                        for (int i = 0; i < c; i++)                 //Заполнение строки
                        {
                            for (int j = 0; j <= NumberOfDots; j++) //Заполнение столбца
                            {
                                if (k == FO.Count || FO[k] == 0)   //Проходим по отрезкам массива ФО от 0 до 0, 
                                    j = c;

                                else if (FO[k] == j)                //И заносим соответствующие значения в матрицу смежности
                                {
                                    Matrix[i, j - 1] = 1;
                                    k++;
                                    j = 0;
                                }
                            }
                            k++;
                        }
                    }
                    return true;
                }
                catch
                {
                    MessageBox.Show("Содержимое файла не есть FO представлением графа", "Возникла ошибка!");
                    ClearAllData();
                    return false;
                } 
            }

            /// <summary>
            /// Метод для визуализации графа
            /// </summary>
            public void Visualize()
            {
                int N = 360 / NumberOfDots;
                double x = 0;
                double y = 0;

                int startX = G.centrX,
                    startY = G.centrY;

                for (int i = 0; i < NumberOfDots; i++)
                {
                    x = G.RTr * Math.Cos(((0 - N) * i) * Math.PI / 180);
                    y = G.RTr * Math.Sin(((0 - N) * i) * Math.PI / 180);
                         
                    Vertex v = new Vertex(startX + Convert.ToInt32(x), startY + Convert.ToInt32(y));
                    V.Add(v);
                }

                int[,] tmp = new int[NumberOfDots, NumberOfDots];

                for (int i = 0; i < NumberOfDots; i++)
                    for (int j = 0; j < NumberOfDots; j++)
                        tmp[i, j] = Matrix[i, j];                

                for (int i = 0; i < NumberOfDots; i++)
                    for (int j = 0; j < NumberOfDots; j++)
                        if (tmp[i, j] == 1)
                        {
                            Edge e = new Edge(i,j);
                            E.Add(e);
                            tmp[i, j] = 0;
                            tmp[j, i] = 0;
                        }
                
                G.DrawAllGraph(V,E);
            }

            /// <summary>
            /// Метод для визуализации Эйлерова пути
            /// </summary>
            public void DrawWay()
            {
                G.DrawWay(V, Way);
            }

            /// <summary>
            /// Метод для чтения из файла
            /// </summary>
            public bool ReadFromFile()
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Прочитать FO-файла для графа";
                openFile.Filter = "txt files (*.txt)|*.txt";
                openFile.RestoreDirectory = true;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (FileToFO(openFile))
                    {
                        if(ConvertFOtoMatrix())
                            return true;
                        else 
                            return false;
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }

            /// <summary>
            /// Метод для сохранения изображения нарисованного графа
            /// </summary>
            public void SaveToFile(string st)
            {
                SaveFileDialog saveFile1 = new SaveFileDialog();
                saveFile1.Title = "Сохранить изображение " + st + " как ...";
                saveFile1.Filter = "Bitmap File(*.bmp)|*.bmp|" + "GIF File(*.gif)|*.gif|" + "JPEG File(*.jpg)|*.jpg|" + "TIF File(*.tif)|*.tif|" + "PNG File(*.png)|*.png";
                saveFile1.RestoreDirectory = true;
                saveFile1.FileName = $"{st}";

                if (saveFile1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFile1.FileName;
                    string str = fileName.Remove(0, fileName.Length - 3);
                    switch (str)
                    {
                        case "bmp":
                            G.bitmap.Save(fileName, ImageFormat.Bmp);
                            break;

                        case "gif":
                            G.bitmap.Save(fileName, ImageFormat.Gif);
                            break;

                        case "jpg":
                            G.bitmap.Save(fileName, ImageFormat.Jpeg);
                            break;

                        case "tif":
                            G.bitmap.Save(fileName, ImageFormat.Tiff);
                            break;

                        case "png":
                            G.bitmap.Save(fileName, ImageFormat.Png);
                            break;

                        default:
                            break;
                    }
                }
            }

            /// <summary>
            /// Метод конвертации FO-файла в FO-массив
            /// </summary>
            /// <param name="dialog">Открытый файл</param>
            /// <returns></returns>
            private bool FileToFO(OpenFileDialog dialog)
            {
                string fileN = "";
                string AllText = "";

                List<string> tmp = new List<string>();

                string[] ArrayWithData = new string[120];

                List<int> OutputArray = new List<int>();
                try
                {
                    fileN = dialog.FileName;
                    AllText = File.ReadAllText(fileN);
                    ArrayWithData = AllText.Split(' ');

                    for (int i = 0; i < ArrayWithData.Length; i++)
                    {
                        if(ArrayWithData[i]!= "")
                            OutputArray.Add(Convert.ToInt32(ArrayWithData[i]));
                    }

                    Name = fileN;
                    int[] a = new int[ArrayWithData.Length];
                    FO = OutputArray;
                    //OutputArray.CopyTo(a, 0);
                    //FO = a;
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Содержимое файла не есть FO представлением графа или в конце массива введен лишний пробел", "Возникла ошибка!");
                    ClearAllData();
                    return false;
                }                
            }
            #endregion
        }

        #region Класс вершин и ребер
        /// <summary>
        /// Класс для вершин
        /// </summary>
        public class Vertex
        {
            /// <summary>
            /// Координаты вершины
            /// </summary>
            public int x, y;

            /// <summary>
            /// Конструктор для создания вершины
            /// </summary>
            /// <param name="x">Х координата</param>
            /// <param name="y">У координата</param>
            public Vertex(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        /// <summary>
        /// Класс для ребер
        /// </summary>
        public class Edge
        {
            /// <summary>
            /// Точки ребер
            /// </summary>
            public int v1, v2;

            /// <summary>
            /// Конструктор для создания ребра
            /// </summary>
            /// <param name="v1"></param>
            /// <param name="v2"></param>
            public Edge(int v1, int v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }
        }
        #endregion

        /// <summary>
        /// Класс для построения визуальной состовляющей графа
        /// </summary>
        public class DrawGraph
        {
            #region Поля и свойства класса DrawGraph

            /// <summary>
            /// Экземляр класса Graph для работы с текущим графом
            /// </summary>
            private Graph graph;

            /// <summary>
            /// 
            /// </summary>
            public Bitmap bitmap;

            /// <summary>
            /// Черное перо
            /// </summary>
            private Pen blackPen;

            /// <summary>
            /// Красное перо
            /// </summary>
            private Pen redPen;

            /// <summary>
            /// Зеленое перо
            /// </summary>
            private Pen greenPen;

            /// <summary>
            /// Холст
            /// </summary>
            private Graphics gr;

            /// <summary>
            /// Шрифт
            /// </summary>
            private Font GraphFont;

            /// <summary>
            /// Кисть
            /// </summary>
            private Brush GraphBrush;

            /// <summary>
            /// Пара координат (x,y) для записывания вычисленных координат вершины
            /// </summary>
            private PointF point;

            /// <summary>
            /// Координаты центра полотна
            /// </summary>
            public int centrX, centrY;

            /// <summary>
            /// Радиус окружности, относительно которой строится граф
            /// </summary>
            public int RTr = 205;

            /// <summary>
            /// Радиус окружности вершины
            /// </summary>
            public int R = 10;
            #endregion

            #region Все методы класса DrawGraph

            /// <summary>
            /// Конструктор c параметрами
            /// </summary>
            /// <param name="width">Ширина полотна</param>
            /// <param name="height">Высота полотна</param>
            public DrawGraph(int width, int height, Graph Grap)
            {
                //Задаем текущий граф
                graph = Grap;
                //Задаем текущий Bitmap
                bitmap = new Bitmap(width, height);
                //Задаем холст для рисования
                gr = Graphics.FromImage(bitmap);

                //Настройки качества изображения
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                //Очищаем полотно
                clearSheet();

                //Создаем черную кисть
                blackPen = new Pen(Color.Black);
                blackPen.Width = 2;

                //Создаем красную кисть
                redPen = new Pen(Color.Red);
                redPen.LineJoin = LineJoin.Miter;
                redPen.Width = 10;
                redPen.EndCap = LineCap.ArrowAnchor;

                //Создаем зеленую кисть
                greenPen = new Pen(Color.Green);
                greenPen.Width = 4;

                //Задаем шрифт 
                GraphFont = new Font("Arial", 10, FontStyle.Bold);
                GraphBrush = Brushes.Black;

                //Определяем центр холста
                centrX = bitmap.Width / 2;
                centrY = bitmap.Height / 2;
            }

            /// <summary>
            /// Метод для очистки поля
            /// </summary>
            public void clearSheet()
            {
                gr.Clear(Color.White);
                gr.Clear(Color.Transparent);
            }

            /// <summary>
            /// Метод пиксельного изображения
            /// </summary>
            /// <returns>Возвращаем bitmap</returns>
            public Bitmap GetBitmap()
            {
                return bitmap;
            }

            /// <summary>
            /// Нарисовать эйлеров путь
            /// </summary>
            public void DrawWay(List<Vertex> Ver, List<int> Way)
            {
                //Создаем экземпляр списка граней для хранения всех граней  
                List<Edge> edges = new List<Edge>();
                
                for (int i = 0; i < Way.Count - 1; i++)
                {
                    //Создаем экземпляр вершины, в которую заносим две рядом стоящие вершины из эйлерова пути
                    Edge e = new Edge(Way[i], Way[i + 1]);
                    edges.Add(e);
                    
                    //Рисуем нашу грань между двумя вершинами
                    DrawEdge(Ver[Way[i]-1], Ver[Way[i+1]-1], e, redPen);
                }
            }

            /// <summary>
            /// Метод для построения вершины
            /// </summary>
            /// <param name="x">Х координата</param>
            /// <param name="y">У координата</param>
            /// <param name="number">Название першины</param>
            public void DrawVertex(int x, int y, string number)
            {
                gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
                gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
                point = new PointF(x - 6, y - 6);
                gr.DrawString(number, GraphFont, GraphBrush, point);
            }

            /// <summary>
            /// Метод для построения граней
            /// </summary>
            public void DrawEdge(Vertex V1, Vertex V2, Edge E, Pen pen)
            {
                if (E.v1 == E.v2)
                {
                    gr.DrawArc(pen, (V1.x - 2 * R), (V1.y - 2 * R), 2 * R, 2 * R, 90, 270);
                    point = new PointF(V1.x - (int)(2.75 * R), V1.y - (int)(2.75 * R));
                    DrawVertex(V1.x, V1.y, (E.v1 + 1).ToString());
                }
                else
                {
                    gr.DrawLine(pen, V1.x, V1.y, V2.x, V2.y);
                    point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
                    DrawVertex(V1.x, V1.y, (E.v1 ).ToString());
                    DrawVertex(V2.x, V2.y, (E.v2 ).ToString());
                }
            }
            /// <summary>
            /// Метод для нарисовывания всего графа
            /// </summary>
            /// <param name="V"></param>
            /// <param name="E"></param>
            public void DrawAllGraph(List<Vertex> V, List<Edge> E)
            {
                gr.Clear(Color.Transparent);
                //рисуем ребра
                for (int i = 0; i < E.Count; i++)
                {
                    if (E[i].v1 == E[i].v2)
                    {
                        gr.DrawArc(greenPen, (V[E[i].v1].x - 2 * R), (V[E[i].v1].y - 2 * R), 2 * R, 2 * R, 90, 270);
                        //point = new PointF(V[E[i].v1].x - (int)(2.75 * R), V[E[i].v1].y - (int)(2.75 * R));
                    }
                    else
                    {
                        gr.DrawLine(greenPen, V[E[i].v1].x, V[E[i].v1].y, V[E[i].v2].x, V[E[i].v2].y);
                        //point = new PointF((V[E[i].v1].x + V[E[i].v2].x) / 2, (V[E[i].v1].y + V[E[i].v2].y) / 2);
                    }
                }

                //рисуем вершины
                for (int i = 0; i < V.Count; i++)
                {
                    DrawVertex(V[i].x, V[i].y, (i + 1).ToString());
                }

                //Задаем количество ребер графа
                graph.NumberOfLine = E.Count;
            }
            #endregion
        }
    }
}
