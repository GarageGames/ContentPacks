singleton TSShapeConstructor(Mantis_Kralmok_HeadDAE)
{
   baseShape = "./Mantis_Kralmok_Head.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_HeadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Head", "960", "970", true, true);
}
