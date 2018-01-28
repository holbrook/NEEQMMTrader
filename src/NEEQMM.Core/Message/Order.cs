using System;
namespace MonoTrader.Message
{
    public enum OrderState
    {
        待报 = 0,  //下单指令还未送入数据处理；
        正报 = 1,  // 下单指令已送达公司，正在等待处理，此时不能确定是否已进场.也称为 “待报”；
        已报 = 2,  // 交易所确认
        已成 = 3,  // 下单指令全部成交；
        部成 = 4,  // 下单指令部份成交；
        废单 = 5,  // 交易所认为委托无效

        待撤 = 10, // 撤单指令还未报到场内。
        正撤 = 11, // 撤单指令已送达公司，正在等待处理，此时不能确定是否已进场；
        已撤 = 12, // 委托指令全部被撤消；        
        部撤 = 13, // 部撤：下单指令中的一部份数量已被撤消；
        撤废 = 14 // 撤废：撤单废单，表示撤单指令失败，原因可能是被撤的下单指令已经成交了或场内无法找到这条下单记录；
    }



    public class Order
    {
        public string ID { get; set; }
        public OrderState Status { get; set; }
        public Order()
        {

        }
    }
}
