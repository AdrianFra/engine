namespace Graphics.Contracts
{
    public interface IFrameBufferFactory
    {
        FrameBuffer GenerateFrameBuffer(int resolutionX, int resolutionY, bool mipmap);
        void SetFrameBuffer(int frameBufferId);
        void UnbindFrameBuffer();
    }
}
