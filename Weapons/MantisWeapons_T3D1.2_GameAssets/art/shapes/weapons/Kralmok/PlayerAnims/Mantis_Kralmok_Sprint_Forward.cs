singleton TSShapeConstructor(Mantis_Kralmok_Sprint_ForwardDAE)
{
   baseShape = "./Mantis_Kralmok_Sprint_Forward.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_Sprint_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Sprint_Forward", "390", "409", true, true);
}
