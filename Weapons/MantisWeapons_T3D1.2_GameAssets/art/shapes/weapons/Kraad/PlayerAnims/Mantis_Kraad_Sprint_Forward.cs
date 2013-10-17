singleton TSShapeConstructor(Mantis_Kraad_Sprint_ForwardDAE)
{
   baseShape = "./Mantis_Kraad_Sprint_Forward.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_Sprint_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Sprint_Forward", "390", "409", true, true);
}
