﻿namespace SingleResponsibilityPrinciple.Abstractions
{
    public interface ITradeMapper
    {
        TradeRecord MapFieldsToRecord(string[] fields);
    }
}
