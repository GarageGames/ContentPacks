singleton TSShapeConstructor(Mantis_Kraad_HeadDAE)
{
   baseShape = "./Mantis_Kraad_Head.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_HeadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Head", "960", "970", true, true);
}
