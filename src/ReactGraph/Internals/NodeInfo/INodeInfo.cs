namespace ReactGraph.Internals.NodeInfo
{
    interface INodeInfo : IValueSource
    {
        void Reevaluate();

        void ValueChanged();

        void UpdateSubscriptions(object newParent);
    }
}