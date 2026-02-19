Place three images here named exactly:
- incendio.jpg
- inundacion.jpg
- sismo.jpg

They will be used by `carrusel.html` as background images for each slide.

Make sure to mark them as Content and Copy to Output Directory in the project, or add the following to the .csproj:

  <ItemGroup>
    <Content Include="webViewCarrusel\images\incendio.jpg">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="webViewCarrusel\images\inundacion.jpg">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="webViewCarrusel\images\sismo.jpg">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
