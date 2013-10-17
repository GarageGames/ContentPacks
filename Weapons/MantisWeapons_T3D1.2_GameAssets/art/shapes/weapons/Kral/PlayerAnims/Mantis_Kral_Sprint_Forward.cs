singleton TSShapeConstructor(Mantis_Kral_Sprint_ForwardDAE)
{
   baseShape = "./Mantis_Kral_Sprint_Forward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_Sprint_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Sprint_Forward", "390", "409", true, true);
}
