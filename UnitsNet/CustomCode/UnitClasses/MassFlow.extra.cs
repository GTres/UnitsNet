﻿// Copyright(c) 2007 Andreas Gullberg Larsen
// https://github.com/anjdreas/UnitsNet
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

// Operator overloads not supported in Universal Windows Platform (WinRT Components)
#if !WINDOWS_UWP
using System;

namespace UnitsNet
{
    public partial struct MassFlow
    {
        public static Mass operator *(MassFlow massFlow, TimeSpan time)
        {
            return Mass.FromKilograms(massFlow.KilogramsPerSecond*time.TotalSeconds);
        }

        public static Mass operator *(TimeSpan time, MassFlow massFlow)
        {
            return Mass.FromKilograms(massFlow.KilogramsPerSecond*time.TotalSeconds);
        }

        public static Mass operator *(MassFlow massFlow, Duration duration)
        {
            return Mass.FromKilograms(massFlow.KilogramsPerSecond*duration.Seconds);
        }

        public static Mass operator *(Duration duration, MassFlow massFlow)
        {
            return Mass.FromKilograms(massFlow.KilogramsPerSecond*duration.Seconds);
        }

        public static Power operator /(MassFlow massFlow, BrakeSpecificFuelConsumption bsfc)
        {
            return Power.FromWatts(massFlow.KilogramsPerSecond / bsfc.KilogramsPerJoule);
        }

        public static BrakeSpecificFuelConsumption operator /(MassFlow massFlow, Power power)
        {
            return BrakeSpecificFuelConsumption.FromKilogramsPerJoule(massFlow.KilogramsPerSecond / power.Watts);
        }

        public static Power operator *(MassFlow massFlow, SpecificEnergy specificEnergy)
        {
            return Power.FromWatts(massFlow.KilogramsPerSecond * specificEnergy.JoulesPerKilogram);
        }
    }
}
#endif