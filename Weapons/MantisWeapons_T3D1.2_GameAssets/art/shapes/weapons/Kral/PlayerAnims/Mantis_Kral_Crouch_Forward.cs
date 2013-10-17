singleton TSShapeConstructor(Mantis_Kral_Crouch_ForwardDAE)
{
   baseShape = "./Mantis_Kral_Crouch_Forward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_Crouch_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Forward", "680", "709", true, true);
}
