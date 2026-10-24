using System.Runtime.InteropServices;

namespace lewis;

public static class FlatRoute
{

    [DllImport("c_api", EntryPoint = "c_api_exec", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Exec(int data);

    [DllImport("c_api", EntryPoint = "c_api_get_num_nodes", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetNumNodes();



    [DllImport("c_api", EntryPoint = "c_api_get_node", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetNode(int index);


    [DllImport("c_api", EntryPoint = "c_api_exit", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Exit();
}