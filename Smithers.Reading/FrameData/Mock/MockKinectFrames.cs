﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.Kinect;

namespace Smithers.Reading.FrameData.Mock
{
    public class MockColorFrame
    {
        public MockFrameDescription FrameDescription {get { return new MockFrameDescription();}}
        public TimeSpan RelativeTime { get { return new TimeSpan(1 , 1, 1); } }

        public void CopyConvertedFrameDataToArray(byte[] buffer, ColorImageFormat format) 
        {
            for (int i = 0; i < buffer.Length; ++i)
            {
                buffer[i] = 128;
            }
        }
    }

    public class MockDepthFrame
    {
        public MockFrameDescription FrameDescription { get { return new MockFrameDescription(); } }
        public TimeSpan RelativeTime { get { return new TimeSpan(1, 1, 1); } }

        public void CopyFrameDataToArray(ushort[] array) 
        {
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = 0x88;                
            }
        }
    }

    public class MockInfraredFrame
    {
        public MockFrameDescription FrameDescription { get { return new MockFrameDescription(); } }
        public TimeSpan RelativeTime { get { return new TimeSpan(1, 1, 1); } }

        public void CopyFrameDataToArray(ushort[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = 0x33;
            }
        }
    }

    public class MockBodyFrame
    {
        public MockFrameDescription FrameDescription { get { return new MockFrameDescription(); } }
        public TimeSpan RelativeTime { get { return new TimeSpan(1, 1, 1); } }


        public Vector4 FloorClipPlane { get { return new Vector4(); }}
    }

    public class MockBodyIndexFrame
    {
        public MockFrameDescription FrameDescription { get { return new MockFrameDescription(); } }
        public TimeSpan RelativeTime { get { return new TimeSpan(1, 1, 1); } }


        public void CopyFrameDataToArray(byte[] array) 
        {
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = 255;
            }
        } 
    }

    public class MockFrameDescription 
    {
        public int Height {get { return 424; }  }
        public int Width { get { return 512; } }
    }
}