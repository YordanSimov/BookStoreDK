﻿using Confluent.Kafka;
using MessagePack;

namespace ProjectDK.BL.Kafka
{
    public class KafkaDeserializer<T> : IDeserializer<T>
    {
        public T Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
        {
            return MessagePackSerializer.Deserialize<T>(data.ToArray());
        }
    }
}
