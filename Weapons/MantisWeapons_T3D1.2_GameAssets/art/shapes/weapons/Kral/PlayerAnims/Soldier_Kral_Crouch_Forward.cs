singleton TSShapeConstructor(Soldier_Kral_Crouch_ForwardDAE)
{
   baseShape = "./Soldier_Kral_Crouch_Forward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_Crouch_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Forward", "390", "419", true, true);
}
