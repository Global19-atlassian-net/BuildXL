// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using BuildXL.FrontEnd.Script.Evaluator;
using BuildXL.FrontEnd.Script.Values;
using TypeScript.Net.Utilities;

namespace BuildXL.FrontEnd.Script.Types
{
    /// <summary>
    /// Type node.
    /// </summary>
    public abstract class Type : Node
    {
        /// <nodoc />
        protected Type(LineInfo location)
            : base(location)
        {
        }

        /// <inheritdoc />
        protected override EvaluationResult DoEval(Context context, ModuleLiteral env, EvaluationStackFrame frame)
        {
            throw new NotImplementedException();
        }
    }
}
