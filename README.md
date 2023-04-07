<div>
  <h1>Hamming Distance</h1>
  <a href="https://www.nuget.org/packages/Hamming-Distance/"> 
   <img src="https://img.shields.io/nuget/dt/Hamming-Distance"
   alt="Nuget downloads" 
   data-canonical-src="https://img.shields.io/nuget/dt/Hamming-Distance?color=2da44e&amp;label=nuget%20downloads&amp;logo=nuget"
   style="max-width: 100%;">
  </a>
</div> 

## Dependencies

| Hamming-Distance | .NET 7 |
|------------------|---------|
| 1.0.0            |   

## Install

```nuget
with .NET CLI 

dotnet add package Hamming-Distance

with Package Manager

NuGet\Install-Package Hamming-Distance

with Package Reference

<PackageReference Include="Hamming-Distance" Version="1.0.0" />
```

## Setup

**Step 1:** Import the namespace

```cs
using Hamming_Distance;
```

## Use

```cs 
Compare.HammingDistance("11011001", "10011101"); // => 2

Compare.HammingDistance(new byte[] { 0x00, 0x00 }, new byte[] { 0x00, 0x0F }); // => 4
```
See <a href='https://en.wikipedia.org/wiki/Hamming_distance#:~:text=In%20information%20theory%2C%20the%20Hamming,the%20corresponding%20symbols%20are%20different.' target='_blank'>Hamming Distance</a>
 
 
