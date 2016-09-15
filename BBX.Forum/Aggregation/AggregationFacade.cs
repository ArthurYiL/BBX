namespace BBX.Aggregation
{
    /// <summary>�ۺϽӿ�</summary>
    public class AggregationFacade
    {
        private static AggregationData baseAggregationData;
        /// <summary>�����ۺ�</summary>
        public static AggregationData BaseAggregation { get { return baseAggregationData; } }

        private static ForumAggregationData forumAggregationData;
        /// <summary>��̳�ۺ�</summary>
        public static ForumAggregationData ForumAggregation { get { return forumAggregationData; } }

        static AggregationFacade()
        {
            baseAggregationData = new AggregationData();
            forumAggregationData = new ForumAggregationData();
            AggregationDataSubject.Attach(baseAggregationData);
            AggregationDataSubject.Attach(forumAggregationData);
        }
    }
}