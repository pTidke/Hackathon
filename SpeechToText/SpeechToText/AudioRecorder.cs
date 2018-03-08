using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Lame;
using System.IO;


namespace SpeechToText
{
    //defining event content for mic stream bytes
    public class AudioBytesEventArgs : System.EventArgs
    {
        public byte[] buffer;       
        public AudioBytesEventArgs(byte[] buffer)
        {
            this.buffer = new byte[buffer.Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                this.buffer[i] = buffer[i];
            }            
        }
    }

    public delegate void AudioBytesEventHandler(object sender, AudioBytesEventArgs e);
    
    //Audio recorder class containing various methods
    class AudioRecorder
    {                
        private WaveInEvent waveInEvent = null;
        private DirectSoundOut waveOut = null;
        private WaveFileWriter wavWriter = null;
        public event AudioBytesEventHandler BytesAccumulated;

        protected virtual void OnBytesAccumulated(AudioBytesEventArgs e)
        {
            BytesAccumulated?.Invoke(this, e);
        }
               
        public void startRecording(string filePath)
        {
            waveInEvent = new WaveInEvent();
            waveInEvent.DeviceNumber = 0;
            waveInEvent.WaveFormat = new WaveFormat(22050, 1);

            waveInEvent.DataAvailable += new EventHandler<WaveInEventArgs>(WaveInEvent_DataAvailable);
            wavWriter = new WaveFileWriter(filePath, waveInEvent.WaveFormat);            
            waveInEvent.StartRecording();
        }

        private void WaveInEvent_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (wavWriter == null) return;
#pragma warning disable CS0618 // Type or member is obsolete
            wavWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
#pragma warning restore CS0618 // Type or member is obsolete
            wavWriter.Flush();
        }

        public void stopRecording()
        {            
            if(wavWriter!= null)
            {
                wavWriter.Dispose();
                wavWriter = null;
            }
            if(waveInEvent != null)
            {
                waveInEvent.StopRecording();
                waveInEvent.Dispose();
                waveInEvent = null;
            }
        }
        MemoryStream stream;

        public DirectSoundOut WaveOut { get => waveOut; set => waveOut = value; }
        public DirectSoundOut WaveOut1 { get => waveOut; set => waveOut = value; }
        public MemoryStream Stream { get => stream; set => stream = value; }

        //this method invokes bytesAccumulated event after certain intervals of the input mic stream
        public void startRecordingByteStream(Stream stream)
        {
            waveInEvent = new WaveInEvent();
            waveInEvent.DeviceNumber = 0;
            waveInEvent.WaveFormat = new WaveFormat(44100,1);
            //stream = new MemoryStream();
            wavWriter = new WaveFileWriter(stream, waveInEvent.WaveFormat);
            waveInEvent.DataAvailable += new EventHandler<WaveInEventArgs>(WaveInEvent_DataToBytes);
            waveInEvent.StartRecording();
        }

        private void WaveInEvent_DataToBytes(object sender, WaveInEventArgs e)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            wavWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
#pragma warning restore CS0618 // Type or member is obsolete
            wavWriter.Flush();
            //byte[] buffer;    
            //stream.
            //OnBytesAccumulated(new AudioBytesEventArgs(e.Buffer));
            //stream.Dispose();
            //stream = new MemoryStream();  
        }        
        
        public void Convert(string sourcePath,string targetPath)
        {
            using (WaveFileReader reader = new WaveFileReader(sourcePath))
            using (LameMP3FileWriter writer = new LameMP3FileWriter(targetPath, reader.WaveFormat, 96))
                reader.CopyTo(writer);
            
        }
    }
}
