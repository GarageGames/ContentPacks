singleton TSShapeConstructor(Mantis_Kralmok_BackDAE)
{
   baseShape = "./Mantis_Kralmok_Back.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Back", "450", "479", true, true);
}
