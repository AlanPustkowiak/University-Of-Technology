using System.Diagnostics;
bool koniec = false;
while (!koniec)
{
    Stopwatch sw = new Stopwatch();
    Console.WriteLine("Podaj rozmiar tablicy: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int[] rand = RandArray(a);
    int[] grow = GrowingArray(a);
    int[] shrink = ShrinkingArray(a);
    int[] cons = ConstArray(a);
    int[] va = VArray(a);
    int[] aa = AArray(a);

    Console.WriteLine("wybierz metodę sortowania: ");
    Console.WriteLine("1. Insertion Sort");
    Console.WriteLine("2. Selection Sort");
    Console.WriteLine("3. Heap Sort");
    Console.WriteLine("4. Merge sort");
    Console.WriteLine("5. Quick sort");
    Console.WriteLine("6. koniec");

    int b = Convert.ToInt32(Console.ReadLine());

    switch (b)
    {
        case 1:
            sw.Start();
            InsertionSort(rand, rand.Length);
            sw.Stop();
            Console.WriteLine($"Randomowa tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            InsertionSort(grow, grow.Length);
            sw.Stop();
            Console.WriteLine($"Rosnaca tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            InsertionSort(shrink, shrink.Length);
            sw.Stop();
            Console.WriteLine($"Malejaca tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            InsertionSort(cons, cons.Length);
            sw.Stop();
            Console.WriteLine($"Stala tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            InsertionSort(va, va.Length);
            sw.Stop();
            Console.WriteLine($"V krzaltna tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            break;
        case 2:
            sw.Start();
            SelectionSort(rand, rand.Length);
            sw.Stop();
            Console.WriteLine($"Randomowa tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            SelectionSort(grow, grow.Length);
            sw.Stop();
            Console.WriteLine($"Rosnaca tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            SelectionSort(shrink, shrink.Length);
            sw.Stop();
            Console.WriteLine($"Malejaca tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            SelectionSort(cons, cons.Length);
            sw.Stop();
            Console.WriteLine($"Stala tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            SelectionSort(va, va.Length);
            sw.Stop();
            Console.WriteLine($"V krzaltna tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            break;
        case 3:
            sw.Start();
            HeapSort(rand, rand.Length);
            sw.Stop();
            Console.WriteLine($"Randomowa tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            HeapSort(grow, grow.Length);
            sw.Stop();
            Console.WriteLine($"Rosnaca tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            HeapSort(shrink, shrink.Length);
            sw.Stop();
            Console.WriteLine($"Malejaca tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            HeapSort(cons, cons.Length);
            sw.Stop();
            Console.WriteLine($"Stala tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            HeapSort(va, va.Length);
            sw.Stop();
            Console.WriteLine($"V krzaltna tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            break;
        case 4:
            sw.Start();
            MergeSort(rand,0, rand.Length-1);
            sw.Stop();
            Console.WriteLine($"Randomowa tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            MergeSort(grow,0, grow.Length-1);
            sw.Stop();
            Console.WriteLine($"Rosnaca tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            MergeSort(shrink,0, shrink.Length - 1);
            sw.Stop();
            Console.WriteLine($"Malejaca tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            MergeSort(cons, 0, cons.Length - 1);
            sw.Stop();
            Console.WriteLine($"Stala tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            sw.Start();
            MergeSort(va, 0, va.Length - 1);
            sw.Stop();
            Console.WriteLine($"V krzaltna tablica czas to: {sw.Elapsed} ms");
            sw.Restart();
            break;
        case 5:
            sw.Start();
            quickSort(aa, 0, aa.Length - 1, 2);
            sw.Stop();
            Console.WriteLine($"Pivot w srodku to czas: {sw.Elapsed}");
            sw.Restart();
            aa = AArray(a);
            sw.Start();
            quickSort(aa, 0, aa.Length - 1, 1);
            sw.Stop();
            Console.WriteLine($"Pivot na ostatnim miejscu czas to: {sw.Elapsed}");
            sw.Restart();
            aa = AArray(a);
            sw.Start();
            quickSort(aa, 0, aa.Length - 1, 3);
            sw.Stop();
            Console.WriteLine($"Pivot losowy czas to: {sw.Elapsed}");
            sw.Restart();
            break;
        case 6:
                koniec = true;
            break;
        default:
            break;
    }

}

static int[] RandArray(int size)
{
    Random rng = new Random();
    List<int> list = new List<int>();

    for (int i = 0; i < size; i++)
    {
        list.Add(rng.Next());
    }

    int[] arr = list.ToArray();

    return arr;
}

static int[] GrowingArray(int size)
{
    Random rng = new Random();
    List<int> list = new List<int>();
    for (int i = 0; i < size; i++)
    {
        list.Add(rng.Next());
    }
    list.Sort();
    int[] arr = list.ToArray();
    
    return arr;
}

static int[] ShrinkingArray(int size)
{
    Random rng = new Random();
    List<int> list = new List<int>();

    for (int i = 0; i < size; i++)
    {
        list.Add(rng.Next());
    }
    list.Sort();
    list.Reverse();
    int[] arr = list.ToArray();

    return arr;
}

static int[] ConstArray(int size)
{
    List<int> list = new List<int>();

    for (int i = 0; i < size; i++)
    {
        list.Add(1);
    }

    int[] arr = list.ToArray();

    return arr;
}

static int[] VArray(int size)
{
    List<int> list = new List<int>();

    for (int i = size/2; i > 0; i--)
    {
        list.Add(i);
    }
    for (int i = 0; i < size/2; i++)
    {
        list.Add(i);
    }

    int[] arr = list.ToArray();

    return arr;
}

static int[] AArray(int size)
{
    List<int> list = new List<int>();

    for (int i = 0; i < size / 2; i++)
    {
        list.Add(i);
    }
    for (int i = size / 2; i > 0; i--)
    {
        list.Add(i);
    }

    int[] arr = list.ToArray();

    return arr;
}

static int[] InsertionSort(int[] array, int length)
{
    for (int i = 1; i < length; i++)
    {
        var key = array[i];
        var flag = 0;
        for (int j = i - 1; j >= 0 && flag != 1;)
        {
            if (key < array[j])
            {
                array[j + 1] = array[j];
                j--;
                array[j + 1] = key;
            }
            else flag = 1;
        }
    }
    return array;
}


static int[] SelectionSort(int[] array, int length)
{
    var arrayLength = length;
    for (int i = 0; i < arrayLength - 1; i++)
    {
        var smallestVal = i;
        for (int j = i + 1; j < arrayLength; j++)
        {
            if (array[j] < array[smallestVal])
            {
                smallestVal = j;
            }
        }
        var tempVar = array[smallestVal];
        array[smallestVal] = array[i];
        array[i] = tempVar;
    }
    return array;
}


static int[] HeapSort(int[] array, int size)
{
    if (size <= 1)
        return array;
    for (int i = size / 2 - 1; i >= 0; i--)
    {
        Heapify(array, size, i);
    }
    for (int i = size - 1; i >= 0; i--)
    {
        var tempVar = array[0];
        array[0] = array[i];
        array[i] = tempVar;
        Heapify(array, i, 0);
    }
    return array;
}

static int[] MergeSort(int[] array, int left, int right)
{
    if (left < right)
    {
        int middle = left + (right - left) / 2;
        MergeSort(array, left, middle);
        MergeSort(array, middle + 1, right);
        MergeArray(array, left, middle, right);
    }
    return array;
}

static void MergeArray(int[] array, int left, int middle, int right)
{
    var leftArrayLength = middle - left + 1;
    var rightArrayLength = right - middle;
    var leftTempArray = new int[leftArrayLength];
    var rightTempArray = new int[rightArrayLength];
    int i, j;
    for (i = 0; i < leftArrayLength; ++i)
        leftTempArray[i] = array[left + i];
    for (j = 0; j < rightArrayLength; ++j)
        rightTempArray[j] = array[middle + 1 + j];
    i = 0;
    j = 0;
    int k = left;
    while (i < leftArrayLength && j < rightArrayLength)
    {
        if (leftTempArray[i] <= rightTempArray[j])
        {
            array[k++] = leftTempArray[i++];
        }
        else
        {
            array[k++] = rightTempArray[j++];
        }
    }
    while (i < leftArrayLength)
    {
        array[k++] = leftTempArray[i++];
    }
    while (j < rightArrayLength)
    {
        array[k++] = rightTempArray[j++];
    }
}

static void Heapify(int[] array, int size, int index)
{
    var largestIndex = index;
    var leftChild = 2 * index + 1;
    var rightChild = 2 * index + 2;
    if (leftChild < size && array[leftChild] > array[largestIndex])
    {
        largestIndex = leftChild;
    }
    if (rightChild < size && array[rightChild] > array[largestIndex])
    {
        largestIndex = rightChild;
    }
    if (largestIndex != index)
    {
        var tempVar = array[index];
        array[index] = array[largestIndex];
        array[largestIndex] = tempVar;
        Heapify(array, size, largestIndex);
    }
}


static void quickSort(int[] arr, int left, int right, int ver)
{
    if (left < right)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(right);
        stack.Push(left);

        while (stack.Count > 0)
        {
            int start = stack.Pop();
            int end = stack.Pop();

            int pivotIndex = Partition(arr, start, end, ver);

            if (pivotIndex - 1 > start)
            {
                stack.Push(pivotIndex - 1);
                stack.Push(start);
            }

            if (pivotIndex + 1 < end)
            {
                stack.Push(end);
                stack.Push(pivotIndex + 1);
            }
        }
    }
}

static int Partition(int[] arr, int left, int right, int ver)
{
    Random rng = new Random();
    int pivot;
    if (ver == 1)
    {
        pivot = arr[right];
    }
    else if (ver == 2)
    {
        pivot = arr[(left + right) / 2];
    }
    else
    {
        pivot = arr[rng.Next(0, arr.Length - 1)];
    }
    int i = left - 1;

    for (int j = left; j < right; j++)
    {
        if (arr[j] < pivot)
        {
            i++;
            Swap(arr, i, j);
        }
    }

    Swap(arr, i + 1, right);

    return i + 1;
}

static void Swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

