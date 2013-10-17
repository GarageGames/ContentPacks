singleton TSShapeConstructor(Soldier_Kralmok_Crouch_ForwardDAE)
{
   baseShape = "./Soldier_Kralmok_Crouch_Forward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_Crouch_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Forward", "380", "409", true, true);
}
