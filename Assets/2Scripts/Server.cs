using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public partial class MainWindow 
{
    TcpListener Server; // 소켓 서버
    TcpClient Client; // 클라이언트

    int port = 8000;

    Thread ListenThread; // 서버 Thread

    public MainWindow()
    {
        //InitializeComponent();

        ListenThread = new Thread(new ThreadStart(Listen));
        ListenThread.Start(); // 서버 시작 (Task로 대체가능)
    }

    private void Listen()
    {
        Server = new TcpListener(IPAddress.Any, port); // 지정된 port로 오는 모든 IP 허용
                                                       //Client = default(TcpClient);

        try
        {
            Server.Start(); // 서버 스타트
            Console.WriteLine("Start Server");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        Client = Server.AcceptTcpClient(); // 접속 대기

        while (true)
        {
            NetworkStream stream = Client.GetStream(); // Client에서 GetStream

            string msg = "Do you hear me"; // test Text
            int byteCount = Encoding.UTF8.GetByteCount(msg); // msg 바이트크기

            byte[] sendBuffer = new byte[byteCount];
            sendBuffer = Encoding.UTF8.GetBytes(msg); // 바이트배열에 msg담기
            stream.Write(sendBuffer, 0, sendBuffer.Length); // stream에 바이트배열 실어보내기
        }
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (Server != null) Server.Stop();
        if (Client != null) Client.Close();
    }
}