using System;

namespace EDC.DesignPattern.Interpreter
{
    /// <summary>
    ///     终结符表达式：动作解释
    /// </summary>
    public class ActionNode : AbstractNode
    {
        private readonly string action;

        public ActionNode(string action)
        {
            this.action = action;
        }

        // 动作（移动方式）表达式的解释操作
        public override string Interpret()
        {
            if (action.Equals("move", StringComparison.OrdinalIgnoreCase))
                return "移动";
            if (action.Equals("run", StringComparison.OrdinalIgnoreCase))
                return "快速移动";
            return "无效指令";
        }
    }
}