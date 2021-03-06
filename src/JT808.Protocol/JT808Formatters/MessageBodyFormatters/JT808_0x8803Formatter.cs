﻿using JT808.Protocol.Extensions;
using JT808.Protocol.MessageBody;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.JT808Formatters.MessageBodyFormatters
{
    public class JT808_0x8803Formatter : IJT808Formatter<JT808_0x8803>
    {
        public JT808_0x8803 Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JT808_0x8803 jT808_0X8803 = new JT808_0x8803();
            jT808_0X8803.MultimediaType = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset);
            jT808_0X8803.ChannelId = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset);
            jT808_0X8803.EventItemCoding = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset);
            jT808_0X8803.StartTime = JT808BinaryExtensions.ReadDateTime6Little(bytes, ref offset);
            jT808_0X8803.EndTime = JT808BinaryExtensions.ReadDateTime6Little(bytes, ref offset);
            jT808_0X8803.MultimediaDeleted = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset);
            readSize = offset;
            return jT808_0X8803;
        }

        public int Serialize(ref byte[] bytes, int offset, JT808_0x8803 value)
        {
            offset += JT808BinaryExtensions.WriteByteLittle(bytes, offset,value.MultimediaType);
            offset += JT808BinaryExtensions.WriteByteLittle(bytes, offset, value.ChannelId);
            offset += JT808BinaryExtensions.WriteByteLittle(bytes, offset, value.EventItemCoding);
            offset += JT808BinaryExtensions.WriteDateTime6Little(bytes, offset, value.StartTime);
            offset += JT808BinaryExtensions.WriteDateTime6Little(bytes, offset, value.EndTime);
            offset += JT808BinaryExtensions.WriteByteLittle(bytes, offset, value.MultimediaDeleted);
            return offset;
        }
    }
}
