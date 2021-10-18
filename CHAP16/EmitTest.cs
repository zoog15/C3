using System;
using static System.Console;
using System.Reflection;
using System.Reflection.Emit;



namespace EmitTest
{
    public class MainApp {
        public static void Main() {
            AssemblyBuilder newAssembly = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);

            ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");

            TypeBuilder newType = newModule.DefineType("Sum1To100");

            MethodBuilder newMethod = newType.DefineMethod("Calculate", MethodAttributes.Public, typeof(int), new Type[0]);

            ILGenerator generator = newMethod.GetILGenerator();

            // 32비트 정수(1)를 계산 스택에 넣음
            generator.Emit(OpCodes.Ldc_I4, 1);

            for (int i = 2; i <= 100; i++) {
                // i를 계산 스택에 넣음
                generator.Emit(OpCodes.Ldc_I4, i);
                // 2개의 값을 꺼내 더하고 그걸 다시 집어넣음
                generator.Emit(OpCodes.Add);
            }
            // 반환
            generator.Emit(OpCodes.Ret);
            newType.CreateType();

            object sum1To100 = Activator.CreateInstance(newType);
            MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
            WriteLine(Calculate.Invoke(sum1To100, null));
        }
    }
}
