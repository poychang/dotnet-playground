var array = new int[2] { 10, 20 };

// 當有使用 unsafe 關鍵字時，建置指令必須加上 /unsafe 參數，或者在 .csproj 中設定 AllowUnsafeBlocks 為 true
// https://learn.microsoft.com/zh-tw/dotnet/api/vslangproj80.csharpprojectconfigurationproperties3.allowunsafeblocks
unsafe
{
    fixed (int* pointer = &array[0])
    {
        var value = pointer;
        Console.WriteLine($"Value: {*value}");
        Console.WriteLine($"Memory Address: {new IntPtr(value)}");

        value += 1;
        Console.WriteLine($"Value: {*value}");
        Console.WriteLine($"Memory Address: {new IntPtr(value)}");

        *value += 1;
        Console.WriteLine($"Value: {*value}");
        Console.WriteLine($"Memory Address: {new IntPtr(value)}");
    }
}
