﻿#region MIT license
// 
// MIT license
//
// Copyright (c) 2007-2008 Jiri Moudry
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
#endregion

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DbLinq.Data.Linq.Sugar.Expressions;

namespace DbLinq.Data.Linq.Sugar.ExpressionMutator.Implementation
{
    public class MemberInitExpressionMutator : IMutableExpression
    {
        protected MemberInitExpression MemberInitExpression { get; private set; }

        public Expression Mutate(IList<Expression> operands)
        {
            var bindings = new List<MemberBinding>();
            int operandIndex = MemberInitExpression.NewExpression.Arguments.Count();
            NewExpression newNewExpression;
            if (MemberInitExpression.NewExpression.Constructor != null)
            {
                newNewExpression = Expression.New(MemberInitExpression.NewExpression.Constructor,
                                                  operands.Take(operandIndex));
            }
            else
            {
                newNewExpression = Expression.New(MemberInitExpression.NewExpression.Type);
            }
            foreach (var memberBinding in MemberInitExpression.Bindings)
            {
                var memberBindingMutator = MemberBindingMutatorFactory.GetMutator(memberBinding);
                int operandsCount = memberBindingMutator.Operands.Count();
                var subOperands = operands.Skip(operandIndex).Take(operandsCount).ToList();
                bindings.Add(memberBindingMutator.Mutate(subOperands));
                operandIndex += operandsCount;
            }
            return Expression.MemberInit(newNewExpression, bindings);
        }

        public IEnumerable<Expression> Operands
        {
            get
            {
                foreach (var newExpressionArgument in MemberInitExpression.NewExpression.Arguments)
                    yield return newExpressionArgument;
                foreach (var memberBinding in MemberInitExpression.Bindings)
                {
                    foreach (var expression in MemberBindingMutatorFactory.GetMutator(memberBinding).Operands)
                        yield return expression;
                }
            }
        }

        public MemberInitExpressionMutator(MemberInitExpression expression)
        {
            MemberInitExpression = expression;
        }
    }
}