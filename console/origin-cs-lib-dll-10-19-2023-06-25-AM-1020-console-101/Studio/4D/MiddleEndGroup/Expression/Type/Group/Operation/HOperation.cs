using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Expression
    {
        public void HOperation(String[] array_SPLIT, Stack item_STACK)
        {
            var boolean_safe__EQUAL_THAN = item_STACK.Count.Equals(0) is true;

            var boolean_safe__EQUAL_OR_MORE_THAN = (array_SPLIT.Length >= 2) is true;

            Boolean shouldRenderContagiousCheck;

            shouldRenderContagiousCheck = boolean_safe__EQUAL_OR_MORE_THAN is false;

            if (shouldRenderContagiousCheck is true)
            {
                ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryEstelScript.Core_EstelScript_Fatal}-{nameof(HOperation)}", String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(Expression) + ' ' + "::" + ' ' + nameof(HOperation) + ' ' + '{',
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(boolean_safe__EQUAL_OR_MORE_THAN) + ':' + ' ' + boolean_safe__EQUAL_OR_MORE_THAN,
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(shouldRenderContagiousCheck) + ':' + ' ' + shouldRenderContagiousCheck,
                    String.Empty + '}'
                }));

                return;
            }
            else
                "false".ToString();

            shouldRenderContagiousCheck = boolean_safe__EQUAL_THAN is true;

            if (shouldRenderContagiousCheck is true)
            {
                ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectoryEstelScript.Core_EstelScript_Fatal}-{nameof(HOperation)}", String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(Expression) + ' ' + "::" + ' ' + nameof(HOperation) + ' ' + '{',
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(boolean_safe__EQUAL_THAN) + ':' + ' ' + boolean_safe__EQUAL_THAN,
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(shouldRenderContagiousCheck) + ':' + ' ' + shouldRenderContagiousCheck,
                    String.Empty + '}'
                }));

                return;
            }
            else
                "false".ToString();

            var reflect = (String)(item_STACK.Peek() as Object);

            var entity__WHITE_SPACE = Convert.ToChar(32);

            var split = reflect.Split(new String[] { entity__WHITE_SPACE.ToString() }, StringSplitOptions.None);

            var array = new String[split.Length];

            var indexer = 0;

            foreach (String stringItem in split)
            {
                String[] splitArray;

                var entity__UNDER_SCORE = Convert.ToChar(95);

                splitArray = stringItem.Split(new String[] { entity__UNDER_SCORE.ToString() }, StringSplitOptions.RemoveEmptyEntries);

                var join = String.Join(entity__WHITE_SPACE.ToString(), splitArray);

                var result = join;

                array[indexer] = result;

                indexer = indexer + 1;

                continue;
            }

            var second = array_SPLIT[1];

            var format = ForgeExpressionFormat(second, true);

            var lower = format.ToLower();

            switch (lower)
            {
                case ExpressionConstant.OperationCSharpInt32Addition:
                    CSharpHostInt32Addition(this, array);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
