﻿namespace ProjectDK.BL.Kafka
{
    public interface IKafkaProducerService<TKey, TValue>
    {
        Task Produce(TKey messageKey, TValue messageValue);
    }
}
