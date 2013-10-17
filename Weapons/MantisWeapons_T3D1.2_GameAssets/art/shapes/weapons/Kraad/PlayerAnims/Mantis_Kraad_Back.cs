singleton TSShapeConstructor(Mantis_Kraad_BackDAE)
{
   baseShape = "./Mantis_Kraad_Back.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Back", "450", "479", true, true);
}
