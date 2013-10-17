singleton TSShapeConstructor(Mantis_Kralmok_FallDAE)
{
   baseShape = "./Mantis_Kralmok_Fall.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_FallDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Fall", "860", "879", true, true);
}
